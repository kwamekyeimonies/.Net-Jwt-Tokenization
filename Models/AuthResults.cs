namespace UserAppAuth.System.Models
{
    public class AuthResults
    {
        public string? Token { get; set; }
        public bool Result { get; set; }
        public List<string>? Error { get; set; }
    }
}