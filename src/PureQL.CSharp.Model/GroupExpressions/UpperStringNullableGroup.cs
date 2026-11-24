using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>upper.string.nullable@group</c>.</summary>
public sealed record UpperStringNullableGroup : IOperator
{
    public UpperStringNullableGroup(DeclaresStringNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableGroup Operand { get; }

    public IType Type => new TypeStringNullable();
}
