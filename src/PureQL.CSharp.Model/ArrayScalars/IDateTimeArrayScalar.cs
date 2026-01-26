namespace PureQL.CSharp.Model.ArrayScalars;

public interface IDateTimeArrayScalar
{
    public IEnumerable<DateTime> Value { get; }
}

public sealed record DateTimeArrayScalar : IDateTimeArrayScalar
{
    public DateTimeArrayScalar(IEnumerable<DateTime> value)
    {
        Value = value;
    }

    public IEnumerable<DateTime> Value { get; }
}
