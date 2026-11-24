using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>nullIfEqual.time.nullable@total</c>.</summary>
public sealed record NullIfEqualTimeNullableTotal : IOperator
{
    public NullIfEqualTimeNullableTotal(TimeNullableTotal left, TimeNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public TimeNullableTotal Left { get; }

    public TimeNullableTotal Right { get; }

    public IType Type => new TypeTimeNullable();
}
