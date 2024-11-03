import json
import random
import datetime
from faker import Faker

# Function to generate random job postings
def generate_job_postings(num_postings):
    fake = Faker()
    job_titles = ['Software Engineer', 'Data Scientist', 'DevOps Engineer', 'Cybersecurity Analyst', 'UI/UX Designer', 'Cloud Architect', 'IT Support Specialist', 'Project Manager', 'QA Engineer', 'Full Stack Developer']
    skills = ['Python', 'Java', 'JavaScript', 'C++', 'AWS', 'Azure', 'Docker', 'Kubernetes', 'SQL', 'NoSQL']
    job_descriptions = [
    "Develop and maintain software applications to meet business requirements.",
    "Design, code, test, and debug software programs.",
    "Collaborate with cross-functional teams to understand user needs and translate them into technical solutions.",
    "Troubleshoot and resolve software defects and performance issues.",
    "Stay up-to-date with the latest software development technologies and best practices.",
    "Write clear and concise documentation for software development projects.",
    "Participate in code reviews and provide feedback to improve code quality.",
    "Analyze system requirements and recommend solutions to improve efficiency and scalability.",
    "Implement security measures to protect software applications from vulnerabilities and attacks.",
    "Provide technical support to users and resolve software-related issues."
    ]
    benefis = [
    "Competitive Salary and Benefits: Enjoy a lucrative compensation package including health insurance, retirement plans, and performance bonuses.",
    "Flexible Work Arrangements: Balance your work and personal life with flexible work hours, remote work options, and unlimited vacation policies.",
    "Continuous Learning and Development: Stay ahead of the curve with access to training programs, conferences, and certifications to enhance your skills.",
    "Cutting-Edge Technology: Work with the latest technologies and tools to build innovative software solutions.",
    "Collaborative and Supportive Culture: Collaborate with talented engineers and industry experts in a positive and inclusive work environment.",
    "Impactful Work: Contribute to projects that have a real-world impact on businesses and individuals.",
    "Career Advancement Opportunities: Advance your career through promotions, leadership roles, and specialized tracks.",
    "Work-Life Balance: Prioritize your well-being with generous time off, wellness programs, and flexible work arrangements.",
    "Global Opportunities: Collaborate with teams around the world and gain international experience.",
    "Innovative Projects: Be part of groundbreaking projects that push the boundaries of technology."
    ]

    job_postings = []
    postId = 1000
    for _ in range(num_postings):
        postId += 1
        posting = {
            "Id": str(postId),
            "JobTitle": random.choice(job_titles),
            "JobDescription": random.choice(job_descriptions),
            "Salary": str(random.randint(50000, 150000)),
            "PostingDate": datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S.%f"),
            "ExpiryDate": (datetime.datetime.now() + datetime.timedelta(days=30)).strftime("%Y-%m-%d %H:%M:%S.%f"),
            "ExperienceRequired": str(random.randint(1, 5)),
            "QualificationRequired": str(f"{random.randint(2, 5)}+ years in {random.choice(skills)}" ),
            "ImageURL": "https://i.pinimg.com/736x/3d/72/98/3d7298d86eca5f461c969581c1a9af31.jpg",
            "JobPostReviewStatus": str(random.randint(0, 1)),
            "IsActive": "true",
            "UserId": "3",
            "CompanyId": "1",
            "JobTypeId": str(random.randint(1, 3)),
            "Benefits": random.choice(benefis),
            "JobLocations": [
                {
                    "Id": str(postId),
                    "StressAddressDetail": f"{fake.street_address()}, {fake.city()}, {fake.state()}",
                    "JobPostId": str(postId),
                    "LocationId": str(random.randint(1, 6))
                }
            ],
            "JobSkillSets": [
                {
                    "Id": str(postId),
                    "SkillSetId": str(random.randint(1, 3)),
                    "JobPostId": str(postId)
                }
            ]
        }
        job_postings.append(posting)

    return job_postings

# Generate 40 job postings
job_data = generate_job_postings(40)

# Save to a JSON file
with open('jobPostData.json', 'w') as f:
    json.dump(job_data, f, indent=4)