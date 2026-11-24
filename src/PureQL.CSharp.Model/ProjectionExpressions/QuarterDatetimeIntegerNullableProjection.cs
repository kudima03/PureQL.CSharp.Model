using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>quarter.datetime.integer.nullable@projection</c>.</summary>
public sealed record QuarterDatetimeIntegerNullableProjection : IOperator
{
    public QuarterDatetimeIntegerNullableProjection(
        DatetimeNullableProjection operand,
        StringNullableProjection? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeNullableProjection Operand { get; }

    public StringNullableProjection? Zone { get; }

    public IType Type => new TypeIntegerNullable();
}
