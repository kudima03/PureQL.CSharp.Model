using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>round.decimal.nullable@group</c>.</summary>
public sealed record RoundDecimalNullableGroup : IOperator
{
    public RoundDecimalNullableGroup(
        IntegerNullableOrDecimalNullableGroup operand,
        IntegerGroup digits
    )
    {
        Operand = operand;
        Digits = digits;
    }

    public IntegerNullableOrDecimalNullableGroup Operand { get; }

    public IntegerGroup Digits { get; }

    public IType Type => new TypeDecimalNullable();
}
