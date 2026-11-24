using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>lower.string.nullable@group</c>.</summary>
public sealed record LowerStringNullableGroup : IOperator
{
    public LowerStringNullableGroup(DeclaresStringNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableGroup Operand { get; }

    public IType Type => new TypeStringNullable();
}
