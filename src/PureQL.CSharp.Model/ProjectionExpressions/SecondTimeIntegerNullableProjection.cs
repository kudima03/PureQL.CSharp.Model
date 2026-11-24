using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>second.time.integer.nullable@projection</c>.</summary>
public sealed record SecondTimeIntegerNullableProjection : IOperator
{
    public SecondTimeIntegerNullableProjection(DeclaresTimeNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
