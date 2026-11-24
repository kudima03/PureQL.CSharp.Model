using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>reverse.string.nullable@group</c>.</summary>
public sealed record ReverseStringNullableGroup : IOperator
{
    public ReverseStringNullableGroup(DeclaresStringNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableGroup Operand { get; }

    public IType Type => new TypeStringNullable();
}
