namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MultiplyIntegerNullableGroup
{
    public MultiplyIntegerNullableGroup(IEnumerable<IntegerNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableGroup> Values { get; }
}
