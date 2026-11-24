using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>startOfMonth.date.nullable@projection</c>.</summary>
public sealed record StartOfMonthDateNullableProjection : IOperator
{
    public StartOfMonthDateNullableProjection(DeclaresDateNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableProjection Operand { get; }

    public IType Type => new TypeDateNullable();
}
