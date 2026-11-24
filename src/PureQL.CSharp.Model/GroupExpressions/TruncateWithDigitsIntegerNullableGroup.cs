using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>truncate.withDigits.integer.nullable@group</c>.</summary>
public sealed record TruncateWithDigitsIntegerNullableGroup : IOperator
{
    public TruncateWithDigitsIntegerNullableGroup(
        IntegerNullableGroup operand,
        IntegerNullableGroup digits
    )
    {
        Operand = operand;
        Digits = digits;
    }

    public IntegerNullableGroup Operand { get; }

    public IntegerNullableGroup Digits { get; }

    public IType Type => new TypeIntegerNullable();
}
