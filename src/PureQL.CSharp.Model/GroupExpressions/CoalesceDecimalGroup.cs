namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceDecimalGroup
{
    public CoalesceDecimalGroup(IEnumerable<DecimalNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableGroup> Values { get; }
}
