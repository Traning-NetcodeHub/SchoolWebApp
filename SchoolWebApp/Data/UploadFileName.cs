namespace SchoolWebApp.Data
{
    public class UploadFileName
    {
        public int Id { get; set; }
        public string? OriginalName { get; set; }
        public string? GeneratedName { get; set; }
        public string? FileLink { get; set; }
        public bool IsPdf { get; set; } = false;
    }
}
