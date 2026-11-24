using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asBoolean.boolean.nullable@group</c>.</summary>
public sealed record AsBooleanBooleanNullableGroup : IOperator
{
    public AsBooleanBooleanNullableGroup(DeclaresStringNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableGroup Operand { get; }

    public IType Type => new TypeBooleanNullable();
}
