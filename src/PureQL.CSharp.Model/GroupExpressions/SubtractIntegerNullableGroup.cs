namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record SubtractIntegerNullableGroup
{
    public SubtractIntegerNullableGroup(IEnumerable<IntegerNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableGroup> Values { get; }
}
