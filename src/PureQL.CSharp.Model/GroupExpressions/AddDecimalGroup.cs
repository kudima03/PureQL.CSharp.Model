namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record AddDecimalGroup
{
    public AddDecimalGroup(IEnumerable<DecimalGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalGroup> Values { get; }
}
