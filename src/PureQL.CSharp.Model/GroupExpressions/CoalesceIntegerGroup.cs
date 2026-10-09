namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceIntegerGroup
{
    public CoalesceIntegerGroup(IEnumerable<IntegerNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableGroup> Values { get; }
}
