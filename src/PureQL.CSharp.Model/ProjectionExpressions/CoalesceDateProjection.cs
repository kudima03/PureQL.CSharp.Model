namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceDateProjection
{
    public CoalesceDateProjection(IEnumerable<DateNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DateNullableProjection> Values { get; }
}
