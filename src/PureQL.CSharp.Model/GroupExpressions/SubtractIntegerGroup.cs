namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record SubtractIntegerGroup
{
    public SubtractIntegerGroup(IEnumerable<IntegerGroup> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerGroup> Values { get; }
}
