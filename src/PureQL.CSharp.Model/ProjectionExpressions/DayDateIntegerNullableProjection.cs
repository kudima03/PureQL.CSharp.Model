using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>day.date.integer.nullable@projection</c>.</summary>
public sealed record DayDateIntegerNullableProjection : IOperator
{
    public DayDateIntegerNullableProjection(DeclaresDateNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
