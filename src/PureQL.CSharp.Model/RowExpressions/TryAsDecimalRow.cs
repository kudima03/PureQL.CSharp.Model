using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>tryAsDecimal@row</c>.</summary>
public sealed record TryAsDecimalRow : IOperator
{
    public TryAsDecimalRow(StringNullableRow operand)
    {
        Operand = operand;
    }

    public StringNullableRow Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
