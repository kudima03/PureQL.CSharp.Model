using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>startOfQuarter.date.nullable@projection</c>.</summary>
public sealed record StartOfQuarterDateNullableProjection : IOperator
{
    public StartOfQuarterDateNullableProjection(DeclaresDateNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableProjection Operand { get; }

    public IType Type => new TypeDateNullable();
}
