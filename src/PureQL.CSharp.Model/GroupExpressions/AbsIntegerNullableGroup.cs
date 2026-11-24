using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>abs.integer.nullable@group</c>.</summary>
public sealed record AbsIntegerNullableGroup : IOperator
{
    public AbsIntegerNullableGroup(DeclaresIntegerNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresIntegerNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
