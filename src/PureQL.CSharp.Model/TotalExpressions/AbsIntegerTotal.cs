using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>abs.integer@total</c>.</summary>
public sealed record AbsIntegerTotal : IOperator
{
    public AbsIntegerTotal(IntegerTotal operand)
    {
        Operand = operand;
    }

    public IntegerTotal Operand { get; }

    public IType Type => new TypeInteger();
}
