using Application;
using Application.Interface;
using Application.Request.User;
using Application.Response.JobPostActivity;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using Moq;
using System.Linq.Expressions;
using Xunit;

namespace Testing.Service
{
    public class UserServiceTest
    {

        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly Mock<IClaimService> _claimServiceMock;
        private readonly UserService _userService;


        public UserServiceTest()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _mapperMock = new Mock<IMapper>();
            _claimServiceMock = new Mock<IClaimService>();
            _userService = new UserService(_unitOfWorkMock.Object, _mapperMock.Object, _claimServiceMock.Object);
        }

        [Fact]
        public async Task GetUserProfileAsync_ShouldReturnNotFound_WhenUserDoesNotExist()
        {
            // Arrange
            int userId = 1;
            _unitOfWorkMock.Setup(uow => uow.UserAccounts.GetAsync(
                    It.IsAny<Expression<Func<UserAccount, bool>>>()!,
                    It.IsAny<Func<IQueryable<UserAccount>, IIncludableQueryable<UserAccount, object>>>()))
                .ReturnsAsync((UserAccount)null!);

            // Act
            var result = await _userService.GetUserProfileAsync(userId);

            // Assert
            Assert.False(result.IsSuccess);
        }

        [Fact]
        public async Task UpdateUserAsync_ShouldReturnNotFound_WhenUserDoesNotExist()
        {
            // Arrange
            var request = new UpdateUserRequest
            {
                Email = "test@example.com",
                PhoneNumber = "1234567890"
            };

            _claimServiceMock.Setup(cs => cs.GetUserClaim())
                .Returns(new ClaimDTO { Id = 1 });

            _unitOfWorkMock.Setup(uow => uow.UserAccounts.GetAsync(
                    It.IsAny<Expression<Func<UserAccount, bool>>>()!))
                .ReturnsAsync((UserAccount)null!);

            // Act
            var result = await _userService.UpdateUserAsync(request);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.Equal("User not found", result.Result);
        }

        [Fact]
        public async Task UpdateUserAsync_ShouldReturnBadRequest_WhenEmailIsInvalid()
        {
            // Arrange
            var request = new UpdateUserRequest
            {
                Email = "invalid-email",
                PhoneNumber = "1234567890"
            };

            _claimServiceMock.Setup(cs => cs.GetUserClaim())
                .Returns(new ClaimDTO { Id = 1 });

            _unitOfWorkMock.Setup(uow => uow.UserAccounts.GetAsync(
                    It.IsAny<Expression<Func<UserAccount, bool>>>()!))
                .ReturnsAsync(new UserAccount());

            // Act
            var result = await _userService.UpdateUserAsync(request);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.Equal("Invalid email format", result.Result);
        }

        [Fact]
        public async Task UpdateUserAsync_ShouldReturnBadRequest_WhenPhoneNumberIsInvalid()
        {
            // Arrange
            var request = new UpdateUserRequest
            {
                Email = "test@example.com",
                PhoneNumber = "invalid-phone"
            };

            _claimServiceMock.Setup(cs => cs.GetUserClaim())
                .Returns(new ClaimDTO { Id = 1 });

            _unitOfWorkMock.Setup(uow => uow.UserAccounts.GetAsync(
                    It.IsAny<Expression<Func<UserAccount, bool>>>()!))
                .ReturnsAsync(new UserAccount());

            // Act
            var result = await _userService.UpdateUserAsync(request);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.Equal("Invalid phone format", result.Result);
        }

        [Fact]
        public async Task UpdateUserAsync_ShouldReturnOk_WhenUpdateIsSuccessful()
        {
            // Arrange
            var request = new UpdateUserRequest
            {
                Email = "test@example.com",
                PhoneNumber = "1234567890"
            };

            var user = new UserAccount();

            _claimServiceMock.Setup(cs => cs.GetUserClaim())
                .Returns(new ClaimDTO { Id = 1 });

            _unitOfWorkMock.Setup(uow => uow.UserAccounts.GetAsync(
                    It.IsAny<Expression<Func<UserAccount, bool>>>()!))
                .ReturnsAsync(user);

            _mapperMock.Setup(mapper => mapper.Map(request, user))
                .Verifiable();

            _unitOfWorkMock.Setup(uow => uow.SaveChangeAsync())
                .Returns(Task.CompletedTask);

            // Act
            var result = await _userService.UpdateUserAsync(request);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.Equal("Update Success", result.Result);
            _mapperMock.Verify();
            _unitOfWorkMock.Verify(uow => uow.SaveChangeAsync(), Times.Once);
        }


        [Fact]
        public async Task GetUserJobPostActivity_ShouldReturnJobPostActivities()
        {
            // Arrange
            var mockClaim = new ClaimDTO { Id = 1 };
            var mockJobPostActivities = new List<JobPostActivity>
    {
        new JobPostActivity { UserId = 1, JobPost = new JobPost { Id = 101, JobTitle = "Software Developer" } },
        new JobPostActivity { UserId = 1, JobPost = new JobPost { Id = 102, JobTitle = "Data Analyst" } }
    };
            var mockJobPostActivityResponses = new List<JobPostActivityResponse>
    {
        new JobPostActivityResponse { JobPostId = 101, JobTitle = "Software Developer" },
        new JobPostActivityResponse { JobPostId = 102, JobTitle = "Data Analyst" }
    };

            _claimServiceMock.Setup(cs => cs.GetUserClaim())
                .Returns(mockClaim);

            _unitOfWorkMock.Setup(uow => uow.JobPostActivities.GetAllAsync(
                    It.IsAny<Expression<Func<JobPostActivity, bool>>>(),
                    It.IsAny<Func<IQueryable<JobPostActivity>, IIncludableQueryable<JobPostActivity, object>>>()))
                .ReturnsAsync(mockJobPostActivities);

            _mapperMock.Setup(m => m.Map<List<JobPostActivityResponse>>(mockJobPostActivities))
                .Returns(mockJobPostActivityResponses);

            // Act
            var result = await _userService.GetUserJobPostActivity();

            // Assert
            Assert.True(result.IsSuccess);
            Assert.NotNull(result.Result);
            Assert.IsType<List<JobPostActivityResponse>>(result.Result);
            Assert.Equal(2, ((List<JobPostActivityResponse>)result.Result).Count);
            Assert.Equal("Software Developer", ((List<JobPostActivityResponse>)result.Result)[0].JobTitle);
        }

        [Fact]
        public async Task AddEmployerToCompany_ShouldReturnBadRequest_WhenUserIsNotEmployer()
        {
            // Arrange
            var request = new AddEmployerToCompanyRequest { CompanyId = 1 };

            _claimServiceMock.Setup(cs => cs.GetUserClaim())
                .Returns(new ClaimDTO { Id = 1, Role = Role.JobSeeker }); // User is not an employer

            // Act
            var result = await _userService.AddEmployerToCompany(request);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.Equal("User be employer", result.Result);
        }

        [Fact]
        public async Task AddEmployerToCompany_ShouldReturnBadRequest_WhenCompanyDoesNotExist()
        {
            // Arrange
            var request = new AddEmployerToCompanyRequest { CompanyId = 1 };

            _claimServiceMock.Setup(cs => cs.GetUserClaim())
                .Returns(new ClaimDTO { Id = 1, Role = Role.Employer });

            _unitOfWorkMock.Setup(uow => uow.Companys.GetAsync(It.IsAny<Expression<Func<Company, bool>>>()))
                .ReturnsAsync((Company)null!); // Company does not exist

            // Act
            var result = await _userService.AddEmployerToCompany(request);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.Equal("Company not exist", result.Result);
        }
    }
}
