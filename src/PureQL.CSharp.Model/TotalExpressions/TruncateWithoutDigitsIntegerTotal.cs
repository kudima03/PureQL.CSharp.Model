using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>truncate.withoutDigits.integer@total</c>.</summary>
public sealed record TruncateWithoutDigitsIntegerTotal : IOperator
{
    public TruncateWithoutDigitsIntegerTotal(DeclaresDecimalTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalTotal Operand { get; }

    public IType Type => new TypeInteger();
}
