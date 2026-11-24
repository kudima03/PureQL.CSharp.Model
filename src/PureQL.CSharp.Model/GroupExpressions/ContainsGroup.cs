using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>contains@group</c>.</summary>
public sealed record ContainsGroup : IOperator
{
    public ContainsGroup(StringNullableGroup operand, StringNullableGroup pattern)
    {
        Operand = operand;
        Pattern = pattern;
    }

    public StringNullableGroup Operand { get; }

    public StringNullableGroup Pattern { get; }

    public IType Type => new TypeBoolean();
}
