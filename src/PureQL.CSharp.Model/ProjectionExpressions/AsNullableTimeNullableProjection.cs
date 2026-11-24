using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asNullable.time.nullable@projection</c>.</summary>
public sealed record AsNullableTimeNullableProjection : IOperator
{
    public AsNullableTimeNullableProjection(TimeProjection operand)
    {
        Operand = operand;
    }

    public TimeProjection Operand { get; }

    public IType Type => new TypeTimeNullable();
}
