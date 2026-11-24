using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>length.integer.nullable@group</c>.</summary>
public sealed record LengthIntegerNullableGroup : IOperator
{
    public LengthIntegerNullableGroup(DeclaresStringNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
