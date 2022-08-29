namespace TestApi.Models.Base
{
    public class ResponseModel<T>
    {
        public T Data { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }
}
