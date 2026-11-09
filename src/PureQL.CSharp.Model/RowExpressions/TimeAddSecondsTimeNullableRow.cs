using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>timeAddSeconds.time.nullable@row</c>.</summary>
public sealed record TimeAddSecondsTimeNullableRow : IOperator
{
    public TimeAddSecondsTimeNullableRow(TimeNullableRow left, DecimalNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public TimeNullableRow Left { get; }

    public DecimalNullableRow Right { get; }

    public IType Type => new TypeTimeNullable();
}
