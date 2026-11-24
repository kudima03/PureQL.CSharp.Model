using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>year.date.integer.nullable@group</c>.</summary>
public sealed record YearDateIntegerNullableGroup : IOperator
{
    public YearDateIntegerNullableGroup(DeclaresDateNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
