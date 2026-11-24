using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>startOfMinute.datetime.nullable@projection</c>.</summary>
public sealed record StartOfMinuteDatetimeNullableProjection : IOperator
{
    public StartOfMinuteDatetimeNullableProjection(
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
