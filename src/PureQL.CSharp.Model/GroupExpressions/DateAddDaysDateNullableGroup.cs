using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>dateAddDays.date.nullable@group</c>.</summary>
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
