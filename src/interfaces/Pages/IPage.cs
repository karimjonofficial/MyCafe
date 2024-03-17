namespace interfaces.Pages;

public interface IPage<out T>
{
    IEnumerable<T> Items { get; }
    int Index { get; }
    int Count { get; }
    int TotalItems { get; }
    int TotalPages { get; }
    string SortedBy { get; }
    string Filter { get; }
}