using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>and@total</c>.</summary>
public sealed record AndTotal : IOperator
{
    public AndTotal(IEnumerable<BooleanTotal> conditions)
    {
        Conditions = conditions;
    }

    public IEnumerable<BooleanTotal> Conditions { get; }

    public IType Type => new TypeBoolean();
}
