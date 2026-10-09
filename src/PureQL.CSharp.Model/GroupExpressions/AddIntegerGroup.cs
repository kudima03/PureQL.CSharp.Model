namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record AddIntegerGroup
{
    public AddIntegerGroup(IEnumerable<IntegerGroup> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerGroup> Values { get; }
}
