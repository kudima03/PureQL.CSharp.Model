using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>sign.integer@total</c>.</summary>
public sealed record SignIntegerTotal : IOperator
{
    public SignIntegerTotal(DecimalTotal operand)
    {
        Operand = operand;
    }

    public DecimalTotal Operand { get; }

    public IType Type => new TypeInteger();
}
