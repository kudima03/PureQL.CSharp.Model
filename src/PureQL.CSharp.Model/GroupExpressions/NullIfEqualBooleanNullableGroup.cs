using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>nullIfEqual.boolean.nullable@group</c>.</summary>
public sealed record NullIfEqualBooleanNullableGroup : IOperator
{
    public NullIfEqualBooleanNullableGroup(
        BooleanNullableGroup left,
        BooleanNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public BooleanNullableGroup Left { get; }

    public BooleanNullableGroup Right { get; }

    public IType Type => new TypeBooleanNullable();
}
