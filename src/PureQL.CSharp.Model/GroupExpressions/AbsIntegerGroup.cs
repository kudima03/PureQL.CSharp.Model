using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>abs.integer@group</c>.</summary>
public sealed record AbsIntegerGroup : IOperator
{
    public AbsIntegerGroup(IntegerGroup operand)
    {
        Operand = operand;
    }

    public IntegerGroup Operand { get; }

    public IType Type => new TypeInteger();
}
