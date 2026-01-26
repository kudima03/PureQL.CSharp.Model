namespace PureQL.CSharp.Model.ArrayScalars;

public interface INullArrayScalar
{
    public IEnumerable<object?> Value { get; }
}

public sealed record NullArrayScalar : INullArrayScalar
{
    private readonly int _count;

    public NullArrayScalar(int count)
    {
        _count = count;
    }

    public IEnumerable<object?> Value =>
        Enumerable.Range(0, _count).Select(x => null as object);
}
