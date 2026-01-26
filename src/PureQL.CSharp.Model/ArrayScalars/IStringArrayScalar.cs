namespace PureQL.CSharp.Model.ArrayScalars;

public interface IStringArrayScalar
{
    public IEnumerable<string> Value { get; }
}

public sealed record StringArrayScalar : IStringArrayScalar
{
    public StringArrayScalar(IEnumerable<string> value)
    {
        Value = value;
    }

    public IEnumerable<string> Value { get; }
}
