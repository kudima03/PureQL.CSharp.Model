namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceDateNullableProjection
{
    public CoalesceDateNullableProjection(IEnumerable<DateNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DateNullableProjection> Values { get; }
}
