namespace SPK.Models
{
    public class ApiResponse
    {
        public int ErrorCode { get; set; }
        public string ErrorMsg { get; set; }        
        public object? Data { get; set; }
    }
}
