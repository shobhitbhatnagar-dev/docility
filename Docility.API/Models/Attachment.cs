namespace Docility.API.Models
{
    public class Attachment
    {
        public int Id { get; set; }
        public string AttachmentUrl { get; set; }
        public Bug Bug { get; set; }
        public int BugId { get; set; }
    }
}