using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

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
