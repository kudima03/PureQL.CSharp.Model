using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>power.decimal@group</c>.</summary>
public sealed record PowerDecimalGroup : IOperator
{
    public PowerDecimalGroup(DecimalGroup operand, DecimalGroup exponent)
    {
        Operand = operand;
        Exponent = exponent;
    }

    public DecimalGroup Operand { get; }

    public DecimalGroup Exponent { get; }

    public IType Type => new TypeDecimal();
}
