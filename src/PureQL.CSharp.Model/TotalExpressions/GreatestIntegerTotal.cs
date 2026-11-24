using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>greatest.integer@total</c>.</summary>
public sealed record GreatestIntegerTotal : IOperator
{
    public GreatestIntegerTotal(IEnumerable<IntegerTotal> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerTotal> Values { get; }

    public IType Type => new TypeInteger();
}
