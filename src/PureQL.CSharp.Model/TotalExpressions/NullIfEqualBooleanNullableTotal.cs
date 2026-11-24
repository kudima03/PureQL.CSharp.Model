using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>nullIfEqual.boolean.nullable@total</c>.</summary>
public sealed record NullIfEqualBooleanNullableTotal : IOperator
{
    public NullIfEqualBooleanNullableTotal(
        BooleanNullableTotal left,
        BooleanNullableTotal right
    )
    {
        Left = left;
        Right = right;
    }

    public BooleanNullableTotal Left { get; }

    public BooleanNullableTotal Right { get; }

    public IType Type => new TypeBooleanNullable();
}
