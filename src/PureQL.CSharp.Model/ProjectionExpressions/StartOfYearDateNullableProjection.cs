using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>startOfYear.date.nullable@projection</c>.</summary>
public sealed record StartOfYearDateNullableProjection : IOperator
{
    public StartOfYearDateNullableProjection(DeclaresDateNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableProjection Operand { get; }

    public IType Type => new TypeDateNullable();
}
