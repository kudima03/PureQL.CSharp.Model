using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asNullable.date.nullable@projection</c>.</summary>
public sealed record AsNullableDateNullableProjection : IOperator
{
    public AsNullableDateNullableProjection(DateProjection operand)
    {
        Operand = operand;
    }

    public DateProjection Operand { get; }

    public IType Type => new TypeDateNullable();
}
