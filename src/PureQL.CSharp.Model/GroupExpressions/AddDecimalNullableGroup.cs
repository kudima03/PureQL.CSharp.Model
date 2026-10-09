namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record AddDecimalNullableGroup
{
    public AddDecimalNullableGroup(IEnumerable<DecimalNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableGroup> Values { get; }
}
