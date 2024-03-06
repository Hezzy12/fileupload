namespace fileupload.Models
{
    public class Files
    {
        public int FileID { get; set; }
        public string fileName { get; set; }
        public byte[] Data { get; set; }
        public string Content { get; set; }
        public DateTime UploadDate { get; set; }
    }
}
