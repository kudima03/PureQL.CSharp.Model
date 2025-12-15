namespace PureQL.CSharp.Model.Scalars;

public interface IDateTimeScalar
{
    public DateTime Value { get; }
}

public sealed record DateTimeScalar : IDateTimeScalar
{
    public DateTimeScalar(DateTime value)
    {
        Value = value;
    }

    public DateTime Value { get; }
}
