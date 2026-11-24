using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asDecimal.string.decimal@total</c>.</summary>
public sealed record AsDecimalStringDecimalTotal : IOperator
{
    public AsDecimalStringDecimalTotal(StringTotal operand)
    {
        Operand = operand;
    }

    public StringTotal Operand { get; }

    public IType Type => new TypeDecimal();
}
