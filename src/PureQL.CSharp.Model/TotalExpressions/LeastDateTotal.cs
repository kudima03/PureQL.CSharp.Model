using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>least.date@total</c>.</summary>
public sealed record LeastDateTotal : IOperator
{
    public LeastDateTotal(IEnumerable<DateTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DateTotal> Values { get; }

    public IType Type => new TypeDate();
}
