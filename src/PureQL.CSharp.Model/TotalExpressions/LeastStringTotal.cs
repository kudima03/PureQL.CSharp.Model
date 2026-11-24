using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>least.string@total</c>.</summary>
public sealed record LeastStringTotal : IOperator
{
    public LeastStringTotal(IEnumerable<StringTotal> values)
    {
        Values = values;
    }

    public IEnumerable<StringTotal> Values { get; }

    public IType Type => new TypeString();
}
