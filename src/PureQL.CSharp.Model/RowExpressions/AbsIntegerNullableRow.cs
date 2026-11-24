using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>abs.integer.nullable@row</c>.</summary>
public sealed record AbsIntegerNullableRow : IOperator
{
    public AbsIntegerNullableRow(DeclaresIntegerNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresIntegerNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
