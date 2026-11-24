using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asString.decimal.string@total</c>.</summary>
public sealed record AsStringDecimalStringTotal : IOperator
{
    public AsStringDecimalStringTotal(DecimalTotal operand)
    {
        Operand = operand;
    }

    public DecimalTotal Operand { get; }

    public IType Type => new TypeString();
}
