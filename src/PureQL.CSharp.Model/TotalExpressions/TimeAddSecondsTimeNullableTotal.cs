using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>timeAddSeconds.time.nullable@total</c>.</summary>
public sealed record TimeAddSecondsTimeNullableTotal : IOperator
{
    public TimeAddSecondsTimeNullableTotal(
        TimeNullableTotal left,
        DecimalNullableTotal right
    )
    {
        Left = left;
        Right = right;
    }

    public TimeNullableTotal Left { get; }

    public DecimalNullableTotal Right { get; }

    public IType Type => new TypeTimeNullable();
}
