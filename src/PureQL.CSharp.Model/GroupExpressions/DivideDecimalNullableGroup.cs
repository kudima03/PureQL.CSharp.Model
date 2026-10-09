namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record DivideDecimalNullableGroup
{
    public DivideDecimalNullableGroup(IEnumerable<DecimalNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableGroup> Values { get; }
}
