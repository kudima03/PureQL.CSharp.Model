using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>startOfMinute.time.nullable@projection</c>.</summary>
public sealed record StartOfMinuteTimeNullableProjection : IOperator
{
    public StartOfMinuteTimeNullableProjection(DeclaresTimeNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableProjection Operand { get; }

    public IType Type => new TypeTimeNullable();
}
