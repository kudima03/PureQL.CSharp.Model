namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceDatetimeProjection
{
    public CoalesceDatetimeProjection(IEnumerable<DatetimeNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableProjection> Values { get; }
}
