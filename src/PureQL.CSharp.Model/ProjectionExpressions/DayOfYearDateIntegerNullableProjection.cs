using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>dayOfYear.date.integer.nullable@projection</c>.</summary>
public sealed record DayOfYearDateIntegerNullableProjection : IOperator
{
    public DayOfYearDateIntegerNullableProjection(DeclaresDateNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
