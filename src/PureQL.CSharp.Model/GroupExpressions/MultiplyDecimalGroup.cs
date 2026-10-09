namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MultiplyDecimalGroup
{
    public MultiplyDecimalGroup(IEnumerable<DecimalGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalGroup> Values { get; }
}
