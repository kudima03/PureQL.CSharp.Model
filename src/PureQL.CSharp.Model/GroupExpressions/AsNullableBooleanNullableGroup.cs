using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asNullable.boolean.nullable@group</c>.</summary>
public sealed record AsNullableBooleanNullableGroup : IOperator
{
    public AsNullableBooleanNullableGroup(BooleanGroup operand)
    {
        Operand = operand;
    }

    public BooleanGroup Operand { get; }

    public IType Type => new TypeBooleanNullable();
}
