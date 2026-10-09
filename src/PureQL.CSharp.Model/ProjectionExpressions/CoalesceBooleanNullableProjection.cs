namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceBooleanNullableProjection
{
    public CoalesceBooleanNullableProjection(
        IEnumerable<BooleanNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableProjection> Values { get; }
}
