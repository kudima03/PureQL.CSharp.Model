namespace PureQL.CSharp.Model.Scalars;

public interface INullScalar
{
    public object? Value { get; }
}

public sealed record NullScalar : INullScalar
{
    public object? Value => null;
}
