using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>timeDiffSeconds.decimal.nullable@total</c>.</summary>
public sealed record TimeDiffSecondsDecimalNullableTotal : IOperator
{
    public TimeDiffSecondsDecimalNullableTotal(
        TimeNullableTotal left,
        TimeNullableTotal right
    )
    {
        Left = left;
        Right = right;
    }

    public TimeNullableTotal Left { get; }

    public TimeNullableTotal Right { get; }

    public IType Type => new TypeDecimalNullable();
}
