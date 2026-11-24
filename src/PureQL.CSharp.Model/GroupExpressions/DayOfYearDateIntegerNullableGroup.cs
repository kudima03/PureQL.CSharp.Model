using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>dayOfYear.date.integer.nullable@group</c>.</summary>
public sealed record DayOfYearDateIntegerNullableGroup : IOperator
{
    public DayOfYearDateIntegerNullableGroup(DeclaresDateNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
