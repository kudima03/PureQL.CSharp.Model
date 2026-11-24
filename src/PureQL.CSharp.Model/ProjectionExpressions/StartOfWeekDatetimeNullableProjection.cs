using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>startOfWeek.datetime.nullable@projection</c>.</summary>
public sealed record StartOfWeekDatetimeNullableProjection : IOperator
{
    public StartOfWeekDatetimeNullableProjection(
        DatetimeNullableProjection operand,
        StringNullableProjection? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeNullableProjection Operand { get; }

    public StringNullableProjection? Zone { get; }

    public IType Type => new TypeDatetimeNullable();
}
