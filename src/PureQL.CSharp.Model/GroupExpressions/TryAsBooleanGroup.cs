using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>tryAsBoolean@group</c>.</summary>
public sealed record TryAsBooleanGroup : IOperator
{
    public TryAsBooleanGroup(StringNullableGroup operand)
    {
        Operand = operand;
    }

    public StringNullableGroup Operand { get; }

    public IType Type => new TypeBooleanNullable();
}
