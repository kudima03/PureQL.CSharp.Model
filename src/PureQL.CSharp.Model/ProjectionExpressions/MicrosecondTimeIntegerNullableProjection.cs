using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>microsecond.time.integer.nullable@projection</c>.</summary>
public sealed record MicrosecondTimeIntegerNullableProjection : IOperator
{
    public MicrosecondTimeIntegerNullableProjection(
        DeclaresTimeNullableProjection operand
    )
    {
        Operand = operand;
    }

    public DeclaresTimeNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
