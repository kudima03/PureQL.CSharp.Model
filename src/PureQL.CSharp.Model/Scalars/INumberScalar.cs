namespace PureQL.CSharp.Model.Scalars;

public interface INumberScalar
{
    public double Value { get; }
}

public sealed record NumberScalar : INumberScalar
{
    public NumberScalar(double value)
    {
        Value = value;
    }

    public double Value { get; }
}
