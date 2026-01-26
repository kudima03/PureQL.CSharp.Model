namespace PureQL.CSharp.Model.ArrayScalars;

public interface IBooleanArrayScalar
{
    public IEnumerable<bool> Value { get; }
}

public sealed record BooleanArrayScalar : IBooleanArrayScalar
{
    public BooleanArrayScalar(IEnumerable<bool> value)
    {
        Value = value;
    }

    public IEnumerable<bool> Value { get; }
}
