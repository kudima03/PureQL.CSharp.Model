using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>greatest.string@total</c>.</summary>
public sealed record GreatestStringTotal : IOperator
{
    public GreatestStringTotal(IEnumerable<StringTotal> values)
    {
        Values = values;
    }

    public IEnumerable<StringTotal> Values { get; }

    public IType Type => new TypeString();
}
