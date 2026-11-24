using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asInteger.integer@total</c>.</summary>
public sealed record AsIntegerIntegerTotal : IOperator
{
    public AsIntegerIntegerTotal(StringTotal operand)
    {
        Operand = operand;
    }

    public StringTotal Operand { get; }

    public IType Type => new TypeInteger();
}
