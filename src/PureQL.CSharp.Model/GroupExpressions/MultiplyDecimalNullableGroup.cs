namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MultiplyDecimalNullableGroup
{
    public MultiplyDecimalNullableGroup(IEnumerable<DecimalNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableGroup> Values { get; }
}
