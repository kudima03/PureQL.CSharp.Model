using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record RoundDecimalGroup : IOperator
{
    public RoundDecimalGroup(DecimalGroup operand, IntegerGroup digits)
    {
        Operand = operand;
        Digits = digits;
    }

    public DecimalGroup Operand { get; }

    public IntegerGroup Digits { get; }

    public IType Type => new TypeDecimal();
}
