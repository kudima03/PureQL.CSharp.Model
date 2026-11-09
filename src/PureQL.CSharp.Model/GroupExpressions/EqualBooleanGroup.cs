using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>equal.boolean@group</c>.</summary>
public sealed record EqualBooleanGroup : IOperator
{
    public EqualBooleanGroup(BooleanNullableGroup left, BooleanNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public BooleanNullableGroup Left { get; }

    public BooleanNullableGroup Right { get; }

    public IType Type => new TypeBoolean();
}
