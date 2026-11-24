using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>endsWith@group</c>.</summary>
public sealed record EndsWithGroup : IOperator
{
    public EndsWithGroup(StringNullableGroup operand, StringNullableGroup pattern)
    {
        Operand = operand;
        Pattern = pattern;
    }

    public StringNullableGroup Operand { get; }

    public StringNullableGroup Pattern { get; }

    public IType Type => new TypeBoolean();
}
