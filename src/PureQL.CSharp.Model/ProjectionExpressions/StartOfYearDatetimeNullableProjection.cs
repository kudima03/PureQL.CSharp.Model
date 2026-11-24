using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>startOfYear.datetime.nullable@projection</c>.</summary>
public sealed record StartOfYearDatetimeNullableProjection : IOperator
{
    public StartOfYearDatetimeNullableProjection(
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
