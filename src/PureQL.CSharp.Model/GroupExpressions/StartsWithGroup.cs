using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startsWith@group</c>.</summary>
public sealed record StartsWithGroup : IOperator
{
    public StartsWithGroup(StringNullableGroup operand, StringNullableGroup pattern)
    {
        Operand = operand;
        Pattern = pattern;
    }

    public StringNullableGroup Operand { get; }

    public StringNullableGroup Pattern { get; }

    public IType Type => new TypeBoolean();
}
