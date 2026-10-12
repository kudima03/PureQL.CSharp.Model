using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record RoundDecimalNullableGroup : IOperator
{
    public RoundDecimalNullableGroup(DecimalNullableGroup operand, IntegerGroup digits)
    {
        Operand = operand;
        Digits = digits;
    }

    public DecimalNullableGroup Operand { get; }

    public IntegerGroup Digits { get; }

    public IType Type => new TypeDecimalNullable();
}
