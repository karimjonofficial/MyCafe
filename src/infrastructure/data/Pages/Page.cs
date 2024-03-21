using interfaces.Pages;

namespace data.Pages;

public class Page<T> : IPage<T>
{
    public ICollection<T> Items { get; }
    public int Index { get; }
    public int Count { get; }
    public int TotalItems { get; }
    public int TotalPages { get; }
    public string SortedBy { get; }
    public string Filter { get; }
}