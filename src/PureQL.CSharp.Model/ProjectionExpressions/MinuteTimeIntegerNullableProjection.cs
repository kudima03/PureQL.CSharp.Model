using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>minute.time.integer.nullable@projection</c>.</summary>
public sealed record MinuteTimeIntegerNullableProjection : IOperator
{
    public MinuteTimeIntegerNullableProjection(DeclaresTimeNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
