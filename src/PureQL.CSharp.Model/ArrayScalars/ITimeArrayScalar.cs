namespace PureQL.CSharp.Model.ArrayScalars;

public interface ITimeArrayScalar
{
    public IEnumerable<TimeOnly> Value { get; }
}

public sealed record TimeArrayScalar : ITimeArrayScalar
{
    public TimeArrayScalar(IEnumerable<TimeOnly> value)
    {
        Value = value;
    }

    public IEnumerable<TimeOnly> Value { get; }
}
