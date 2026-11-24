using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>hour.time.integer.nullable@projection</c>.</summary>
public sealed record HourTimeIntegerNullableProjection : IOperator
{
    public HourTimeIntegerNullableProjection(DeclaresTimeNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
