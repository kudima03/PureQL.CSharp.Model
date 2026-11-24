using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>greatest.boolean@total</c>.</summary>
public sealed record GreatestBooleanTotal : IOperator
{
    public GreatestBooleanTotal(IEnumerable<BooleanTotal> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanTotal> Values { get; }

    public IType Type => new TypeBoolean();
}
