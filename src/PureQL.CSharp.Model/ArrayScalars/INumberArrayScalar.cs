namespace PureQL.CSharp.Model.ArrayScalars;

public interface INumberArrayScalar
{
    public IEnumerable<double> Value { get; }
}

public sealed record NumberArrayScalar : INumberArrayScalar
{
    public NumberArrayScalar(IEnumerable<double> value)
    {
        Value = value;
    }

    public IEnumerable<double> Value { get; }
}
