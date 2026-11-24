using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>nullIfEqual.date.nullable@total</c>.</summary>
public sealed record NullIfEqualDateNullableTotal : IOperator
{
    public NullIfEqualDateNullableTotal(DateNullableTotal left, DateNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public DateNullableTotal Left { get; }

    public DateNullableTotal Right { get; }

    public IType Type => new TypeDateNullable();
}
