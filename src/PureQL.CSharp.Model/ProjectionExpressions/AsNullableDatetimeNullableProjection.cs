using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asNullable.datetime.nullable@projection</c>.</summary>
public sealed record AsNullableDatetimeNullableProjection : IOperator
{
    public AsNullableDatetimeNullableProjection(DatetimeProjection operand)
    {
        Operand = operand;
    }

    public DatetimeProjection Operand { get; }

    public IType Type => new TypeDatetimeNullable();
}
