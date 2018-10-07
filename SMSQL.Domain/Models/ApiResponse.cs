using SMSQL.Domain.Models.Response;

namespace SMSQL.Domain.Models
{
    public class ApiResponse<T>
    {
        public ApiResponse()
        {
            Success = true;
        }

        public bool Success { get; set; }

        public string ErrorCod { get; set; }
        public string Error { get; set; }
        public T Data { get; set; }

        public void SetError(string error)
        {
            Success = false;
            Error = error;
        }
    }
}
