using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>quarter.date.integer.nullable@projection</c>.</summary>
public sealed record QuarterDateIntegerNullableProjection : IOperator
{
    public QuarterDateIntegerNullableProjection(DeclaresDateNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
