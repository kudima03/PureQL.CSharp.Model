using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>truncate.decimal@total</c>.</summary>
public sealed record TruncateDecimalTotal : IOperator
{
    public TruncateDecimalTotal(DeclaresDecimalTotal operand, IntegerTotal digits)
    {
        Operand = operand;
        Digits = digits;
    }

    public DeclaresDecimalTotal Operand { get; }

    public IntegerTotal Digits { get; }

    public IType Type => new TypeDecimal();
}
