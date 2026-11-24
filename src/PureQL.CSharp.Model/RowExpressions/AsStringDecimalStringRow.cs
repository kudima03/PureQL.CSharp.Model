using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asString.decimal.string@row</c>.</summary>
public sealed record AsStringDecimalStringRow : IOperator
{
    public AsStringDecimalStringRow(DecimalRow operand)
    {
        Operand = operand;
    }

    public DecimalRow Operand { get; }

    public IType Type => new TypeString();
}
