namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record SubtractDecimalGroup
{
    public SubtractDecimalGroup(IEnumerable<DecimalGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalGroup> Values { get; }
}
