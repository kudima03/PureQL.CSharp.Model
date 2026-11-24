using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>foldCase.string.nullable@row</c>.</summary>
public sealed record FoldCaseStringNullableRow : IOperator
{
    public FoldCaseStringNullableRow(DeclaresStringNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableRow Operand { get; }

    public IType Type => new TypeStringNullable();
}
