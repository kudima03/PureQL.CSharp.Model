using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record AndTotal : IOperator
{
    public AndTotal(IEnumerable<BooleanTotal> conditions)
    {
        Conditions = conditions;
    }

    public IEnumerable<BooleanTotal> Conditions { get; }

    public IType Type => new TypeBoolean();
}
