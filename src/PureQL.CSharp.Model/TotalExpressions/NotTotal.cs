using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record NotTotal : IOperator
{
    public NotTotal(BooleanTotal condition)
    {
        Condition = condition;
    }

    public BooleanTotal Condition { get; }

    public IType Type => new TypeBoolean();
}
