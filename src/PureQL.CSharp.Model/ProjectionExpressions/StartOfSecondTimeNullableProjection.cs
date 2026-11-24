using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>startOfSecond.time.nullable@projection</c>.</summary>
public sealed record StartOfSecondTimeNullableProjection : IOperator
{
    public StartOfSecondTimeNullableProjection(DeclaresTimeNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableProjection Operand { get; }

    public IType Type => new TypeTimeNullable();
}
