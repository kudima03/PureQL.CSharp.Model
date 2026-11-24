using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>second.datetime.integer.nullable@projection</c>.</summary>
public sealed record SecondDatetimeIntegerNullableProjection : IOperator
{
    public SecondDatetimeIntegerNullableProjection(
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
