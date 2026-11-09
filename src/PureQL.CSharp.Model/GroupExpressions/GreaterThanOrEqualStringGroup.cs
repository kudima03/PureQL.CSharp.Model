using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>greaterThanOrEqual.string@group</c>.</summary>
public sealed record GreaterThanOrEqualStringGroup : IOperator
{
    public GreaterThanOrEqualStringGroup(
        StringNullableGroup left,
        StringNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public StringNullableGroup Left { get; }

    public StringNullableGroup Right { get; }

    public IType Type => new TypeBoolean();
}
