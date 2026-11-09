using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>dateAddDays.date.nullable@total</c>.</summary>
public sealed record DateAddDaysDateNullableTotal : IOperator
{
    public DateAddDaysDateNullableTotal(
        DateNullableTotal left,
        IntegerNullableTotal right
    )
    {
        Left = left;
        Right = right;
    }

    public DateNullableTotal Left { get; }

    public IntegerNullableTotal Right { get; }

    public IType Type => new TypeDateNullable();
}
