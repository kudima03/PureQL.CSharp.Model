using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>abs.decimal@row</c>.</summary>
public sealed record AbsDecimalRow : IOperator
{
    public AbsDecimalRow(DeclaresDecimalRow operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalRow Operand { get; }

    public IType Type => new TypeDecimal();
}
