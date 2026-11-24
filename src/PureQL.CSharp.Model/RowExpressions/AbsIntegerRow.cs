using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>abs.integer@row</c>.</summary>
public sealed record AbsIntegerRow : IOperator
{
    public AbsIntegerRow(IntegerRow operand)
    {
        Operand = operand;
    }

    public IntegerRow Operand { get; }

    public IType Type => new TypeInteger();
}
