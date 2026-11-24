using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>greatest.date@total</c>.</summary>
public sealed record GreatestDateTotal : IOperator
{
    public GreatestDateTotal(IEnumerable<DateTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DateTotal> Values { get; }

    public IType Type => new TypeDate();
}
