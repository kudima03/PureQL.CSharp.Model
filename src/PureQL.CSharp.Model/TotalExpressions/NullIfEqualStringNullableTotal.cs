using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>nullIfEqual.string.nullable@total</c>.</summary>
public sealed record NullIfEqualStringNullableTotal : IOperator
{
    public NullIfEqualStringNullableTotal(
        StringNullableTotal left,
        StringNullableTotal right
    )
    {
        Left = left;
        Right = right;
    }

    public StringNullableTotal Left { get; }

    public StringNullableTotal Right { get; }

    public IType Type => new TypeStringNullable();
}
