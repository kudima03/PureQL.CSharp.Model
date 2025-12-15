namespace PureQL.CSharp.Model.Scalars;

public interface ITimeScalar
{
    public TimeOnly Value { get; }
}

public sealed record TimeScalar : ITimeScalar
{
    public TimeScalar(TimeOnly value)
    {
        Value = value;
    }

    public TimeOnly Value { get; }
}
