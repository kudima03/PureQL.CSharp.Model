using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>startOfWeek.date.nullable@projection</c>.</summary>
public sealed record StartOfWeekDateNullableProjection : IOperator
{
    public StartOfWeekDateNullableProjection(DeclaresDateNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableProjection Operand { get; }

    public IType Type => new TypeDateNullable();
}
