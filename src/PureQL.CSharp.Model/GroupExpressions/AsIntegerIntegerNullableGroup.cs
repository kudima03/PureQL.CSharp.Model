using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asInteger.integer.nullable@group</c>.</summary>
public sealed record AsIntegerIntegerNullableGroup : IOperator
{
    public AsIntegerIntegerNullableGroup(DeclaresStringNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
