namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceDatetimeNullableProjection
{
    public CoalesceDatetimeNullableProjection(
        IEnumerable<DatetimeNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableProjection> Values { get; }
}
