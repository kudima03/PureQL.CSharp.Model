using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>lessThan.date@group</c>.</summary>
public sealed record LessThanDateGroup : IOperator
{
    public LessThanDateGroup(DateNullableGroup left, DateNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public DateNullableGroup Left { get; }

    public DateNullableGroup Right { get; }

    public IType Type => new TypeBoolean();
}
