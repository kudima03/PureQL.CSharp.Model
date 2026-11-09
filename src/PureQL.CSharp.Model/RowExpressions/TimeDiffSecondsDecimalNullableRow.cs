using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>timeDiffSeconds.decimal.nullable@row</c>.</summary>
public sealed record TimeDiffSecondsDecimalNullableRow : IOperator
{
    public TimeDiffSecondsDecimalNullableRow(TimeNullableRow left, TimeNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public TimeNullableRow Left { get; }

    public TimeNullableRow Right { get; }

    public IType Type => new TypeDecimalNullable();
}
