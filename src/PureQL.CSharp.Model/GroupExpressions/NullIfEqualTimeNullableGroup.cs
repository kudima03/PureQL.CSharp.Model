using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>nullIfEqual.time.nullable@group</c>.</summary>
public sealed record NullIfEqualTimeNullableGroup : IOperator
{
    public NullIfEqualTimeNullableGroup(TimeNullableGroup left, TimeNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public TimeNullableGroup Left { get; }

    public TimeNullableGroup Right { get; }

    public IType Type => new TypeTimeNullable();
}
