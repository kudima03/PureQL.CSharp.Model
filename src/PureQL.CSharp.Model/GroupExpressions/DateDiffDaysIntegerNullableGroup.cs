using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>dateDiffDays.integer.nullable@group</c>.</summary>
public sealed record DateDiffDaysIntegerNullableGroup : IOperator
{
    public DateDiffDaysIntegerNullableGroup(
        DateNullableGroup left,
        DateNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public DateNullableGroup Left { get; }

    public DateNullableGroup Right { get; }

    public IType Type => new TypeIntegerNullable();
}
