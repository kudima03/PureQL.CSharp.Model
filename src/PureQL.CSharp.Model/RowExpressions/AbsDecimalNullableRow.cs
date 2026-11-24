using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>abs.decimal.nullable@row</c>.</summary>
public sealed record AbsDecimalNullableRow : IOperator
{
    public AbsDecimalNullableRow(DeclaresDecimalNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalNullableRow Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
