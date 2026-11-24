using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>weekYear.date.integer.nullable@projection</c>.</summary>
public sealed record WeekYearDateIntegerNullableProjection : IOperator
{
    public WeekYearDateIntegerNullableProjection(DeclaresDateNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
