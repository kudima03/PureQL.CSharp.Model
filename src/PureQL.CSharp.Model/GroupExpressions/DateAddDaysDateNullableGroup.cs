using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record DateAddDaysDateNullableGroup : IOperator
{
    public DateAddDaysDateNullableGroup(
        DateNullableGroup left,
        IntegerNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public DateNullableGroup Left { get; }

    public IntegerNullableGroup Right { get; }

    public IType Type => new TypeDateNullable();
}
