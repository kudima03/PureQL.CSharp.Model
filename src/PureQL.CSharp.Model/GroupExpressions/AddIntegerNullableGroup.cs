namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record AddIntegerNullableGroup
{
    public AddIntegerNullableGroup(IEnumerable<IntegerNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableGroup> Values { get; }
}
