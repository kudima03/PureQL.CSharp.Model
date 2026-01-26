namespace PureQL.CSharp.Model.ArrayScalars;

public interface IDateArrayScalar
{
    public IEnumerable<DateOnly> Value { get; }
}

public sealed record DateArrayScalar : IDateArrayScalar
{
    public DateArrayScalar(IEnumerable<DateOnly> value)
    {
        Value = value;
    }

    public IEnumerable<DateOnly> Value { get; }
}
