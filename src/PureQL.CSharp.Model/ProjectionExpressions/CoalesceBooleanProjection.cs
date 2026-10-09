namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceBooleanProjection
{
    public CoalesceBooleanProjection(IEnumerable<BooleanNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableProjection> Values { get; }
}
