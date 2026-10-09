namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record DivideDecimalGroup
{
    public DivideDecimalGroup(IEnumerable<DecimalGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalGroup> Values { get; }
}
