namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record SubtractDecimalNullableGroup
{
    public SubtractDecimalNullableGroup(IEnumerable<DecimalNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableGroup> Values { get; }
}
