using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

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
