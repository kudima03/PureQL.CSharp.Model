using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>dateAddDays.date.nullable@row</c>.</summary>
public sealed record DateAddDaysDateNullableRow : IOperator
{
    public DateAddDaysDateNullableRow(DateNullableRow left, IntegerNullableRow right)
    {
        Left = left;
        Right = right;
    }

    public DateNullableRow Left { get; }

    public IntegerNullableRow Right { get; }

    public IType Type => new TypeDateNullable();
}
