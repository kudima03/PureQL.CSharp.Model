using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>startOfHour.time.nullable@projection</c>.</summary>
public sealed record StartOfHourTimeNullableProjection : IOperator
{
    public StartOfHourTimeNullableProjection(DeclaresTimeNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableProjection Operand { get; }

    public IType Type => new TypeTimeNullable();
}
