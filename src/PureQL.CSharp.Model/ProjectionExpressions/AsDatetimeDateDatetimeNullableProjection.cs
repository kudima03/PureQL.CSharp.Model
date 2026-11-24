using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asDatetime.date.datetime.nullable@projection</c>.</summary>
public sealed record AsDatetimeDateDatetimeNullableProjection : IOperator
{
    public AsDatetimeDateDatetimeNullableProjection(
        DateNullableProjection operand,
        StringNullableProjection? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DateNullableProjection Operand { get; }

    public StringNullableProjection? Zone { get; }

    public IType Type => new TypeDatetimeNullable();
}
