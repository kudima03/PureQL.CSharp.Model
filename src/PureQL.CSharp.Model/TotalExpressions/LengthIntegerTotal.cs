using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>length.integer@total</c>.</summary>
public sealed record LengthIntegerTotal : IOperator
{
    public LengthIntegerTotal(StringTotal operand)
    {
        Operand = operand;
    }

    public StringTotal Operand { get; }

    public IType Type => new TypeInteger();
}
