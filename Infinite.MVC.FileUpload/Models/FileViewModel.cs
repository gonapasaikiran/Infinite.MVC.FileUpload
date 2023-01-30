namespace Infinite.MVC.FileUpload.Models
{
    public class FileViewModel
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
    }
}
