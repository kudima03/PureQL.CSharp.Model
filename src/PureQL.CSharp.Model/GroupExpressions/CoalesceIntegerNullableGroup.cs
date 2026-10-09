namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceIntegerNullableGroup
{
    public CoalesceIntegerNullableGroup(IEnumerable<IntegerNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableGroup> Values { get; }
}
