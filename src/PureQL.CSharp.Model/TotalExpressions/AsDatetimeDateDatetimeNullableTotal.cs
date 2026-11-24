using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asDatetime.date.datetime.nullable@total</c>.</summary>
public sealed record AsDatetimeDateDatetimeNullableTotal : IOperator
{
    public AsDatetimeDateDatetimeNullableTotal(
        DateNullableTotal operand,
        StringNullableTotal? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DateNullableTotal Operand { get; }

    public StringNullableTotal? Zone { get; }

    public IType Type => new TypeDatetimeNullable();
}
