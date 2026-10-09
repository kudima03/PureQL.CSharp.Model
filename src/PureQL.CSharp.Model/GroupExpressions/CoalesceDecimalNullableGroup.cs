namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceDecimalNullableGroup
{
    public CoalesceDecimalNullableGroup(IEnumerable<DecimalNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableGroup> Values { get; }
}
