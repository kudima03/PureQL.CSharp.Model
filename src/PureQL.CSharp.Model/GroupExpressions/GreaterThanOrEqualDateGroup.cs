using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>greaterThanOrEqual.date@group</c>.</summary>
public sealed record GreaterThanOrEqualDateGroup : IOperator
{
    public GreaterThanOrEqualDateGroup(DateNullableGroup left, DateNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public DateNullableGroup Left { get; }

    public DateNullableGroup Right { get; }

    public IType Type => new TypeBoolean();
}
