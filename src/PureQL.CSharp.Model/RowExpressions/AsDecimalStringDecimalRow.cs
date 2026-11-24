using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asDecimal.string.decimal@row</c>.</summary>
public sealed record AsDecimalStringDecimalRow : IOperator
{
    public AsDecimalStringDecimalRow(StringRow operand)
    {
        Operand = operand;
    }

    public StringRow Operand { get; }

    public IType Type => new TypeDecimal();
}
