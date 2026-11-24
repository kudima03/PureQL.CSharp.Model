using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>nullIfEqual.date.nullable@group</c>.</summary>
public sealed record NullIfEqualDateNullableGroup : IOperator
{
    public NullIfEqualDateNullableGroup(DateNullableGroup left, DateNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public DateNullableGroup Left { get; }

    public DateNullableGroup Right { get; }

    public IType Type => new TypeDateNullable();
}
