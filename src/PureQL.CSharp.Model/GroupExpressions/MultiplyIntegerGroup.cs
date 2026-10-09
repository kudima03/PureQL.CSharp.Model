namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MultiplyIntegerGroup
{
    public MultiplyIntegerGroup(IEnumerable<IntegerGroup> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerGroup> Values { get; }
}
