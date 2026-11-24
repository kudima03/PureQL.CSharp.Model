using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>foldCase.string.nullable@total</c>.</summary>
public sealed record FoldCaseStringNullableTotal : IOperator
{
    public FoldCaseStringNullableTotal(DeclaresStringNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableTotal Operand { get; }

    public IType Type => new TypeStringNullable();
}
