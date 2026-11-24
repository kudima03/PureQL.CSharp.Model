using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>sign.integer@row</c>.</summary>
public sealed record SignIntegerRow : IOperator
{
    public SignIntegerRow(DecimalRow operand)
    {
        Operand = operand;
    }

    public DecimalRow Operand { get; }

    public IType Type => new TypeInteger();
}
