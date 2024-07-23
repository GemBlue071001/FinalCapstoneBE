
namespace Domain.Entities
{
    public class Message : Base
    {
        public int Id { get; set; }
        /*MessageId int pk
  UserId int
  Content String
  SendDate datetime
  ConservationID int*/
        public string Content { get; set; }
        public DateTime SendDate { get; set; }
    }
}
