using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>lessThanOrEqual.time@group</c>.</summary>
public sealed record LessThanOrEqualTimeGroup : IOperator
{
    public LessThanOrEqualTimeGroup(TimeNullableGroup left, TimeNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public TimeNullableGroup Left { get; }

    public TimeNullableGroup Right { get; }

    public IType Type => new TypeBoolean();
}
