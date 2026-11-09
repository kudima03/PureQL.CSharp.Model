using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>lessThanOrEqual.datetime@group</c>.</summary>
public sealed record LessThanOrEqualDatetimeGroup : IOperator
{
    public LessThanOrEqualDatetimeGroup(
        DatetimeNullableGroup left,
        DatetimeNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableGroup Left { get; }

    public DatetimeNullableGroup Right { get; }

    public IType Type => new TypeBoolean();
}
