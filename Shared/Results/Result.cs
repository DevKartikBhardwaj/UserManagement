namespace Shared.Results
{
    public class Result<T>
    {
        public T? Data { get; set; }
        public List<T> DataList { get; set; } = [];
        public bool hasError { get; set; } = false;
        public string? ErrorMessage { get; set; }

    }
}
