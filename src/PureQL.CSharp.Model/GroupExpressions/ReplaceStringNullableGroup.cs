using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>replace.string.nullable@group</c>.</summary>
public sealed record ReplaceStringNullableGroup : IOperator
{
    public ReplaceStringNullableGroup(
        StringNullableGroup operand,
        StringNullableGroup pattern,
        StringNullableGroup replacement
    )
    {
        Operand = operand;
        Pattern = pattern;
        Replacement = replacement;
    }

    public StringNullableGroup Operand { get; }

    public StringNullableGroup Pattern { get; }

    public StringNullableGroup Replacement { get; }

    public IType Type => new TypeStringNullable();
}
