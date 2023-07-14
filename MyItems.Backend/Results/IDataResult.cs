namespace MyItems.Backend.Results
{
    internal interface IDataResult<T>
    {
        T Data { get; }
    }
}