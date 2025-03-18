namespace Warehouse_Management.Models
{
    public class Response<T>
    {
        public int StatusCode { get; set; }

        public bool IsSuccessful => StatusCode == 200;

        public string Message { get; set; }

        public T Data { get; set; }
    }
}
