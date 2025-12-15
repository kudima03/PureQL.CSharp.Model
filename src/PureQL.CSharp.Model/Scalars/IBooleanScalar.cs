namespace PureQL.CSharp.Model.Scalars;

public interface IBooleanScalar
{
    public bool Value { get; }
}

public sealed record BooleanScalar : IBooleanScalar
{
    public BooleanScalar(bool value)
    {
        Value = value;
    }

    public bool Value { get; }
}
