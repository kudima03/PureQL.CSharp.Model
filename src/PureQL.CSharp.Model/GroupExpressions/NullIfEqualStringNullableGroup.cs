using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>nullIfEqual.string.nullable@group</c>.</summary>
public sealed record NullIfEqualStringNullableGroup : IOperator
{
    public NullIfEqualStringNullableGroup(
        StringNullableGroup left,
        StringNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public StringNullableGroup Left { get; }

    public StringNullableGroup Right { get; }

    public IType Type => new TypeStringNullable();
}
