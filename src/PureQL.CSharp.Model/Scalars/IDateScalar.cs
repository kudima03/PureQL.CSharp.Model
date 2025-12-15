namespace PureQL.CSharp.Model.Scalars;

public interface IDateScalar
{
    public DateOnly Value { get; }
}

public sealed record DateScalar : IDateScalar
{
    public DateScalar(DateOnly value)
    {
        Value = value;
    }

    public DateOnly Value { get; }
}
