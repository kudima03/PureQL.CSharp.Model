using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

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
