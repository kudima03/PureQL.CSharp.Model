using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>truncate.decimal.nullable@group</c>.</summary>
public sealed record TruncateDecimalNullableGroup : IOperator
{
    public TruncateDecimalNullableGroup(
        DecimalOrDecimalNullableGroup operand,
        IntegerNullableGroup digits
    )
    {
        Operand = operand;
        Digits = digits;
    }

    public DecimalOrDecimalNullableGroup Operand { get; }

    public IntegerNullableGroup Digits { get; }

    public IType Type => new TypeDecimalNullable();
}
