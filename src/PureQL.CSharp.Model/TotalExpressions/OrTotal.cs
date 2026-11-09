using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>or@total</c>.</summary>
public sealed record OrTotal : IOperator
{
    public OrTotal(IEnumerable<BooleanTotal> conditions)
    {
        Conditions = conditions;
    }

    public IEnumerable<BooleanTotal> Conditions { get; }

    public IType Type => new TypeBoolean();
}
