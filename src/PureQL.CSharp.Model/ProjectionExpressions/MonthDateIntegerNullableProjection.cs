using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>month.date.integer.nullable@projection</c>.</summary>
public sealed record MonthDateIntegerNullableProjection : IOperator
{
    public MonthDateIntegerNullableProjection(DeclaresDateNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
