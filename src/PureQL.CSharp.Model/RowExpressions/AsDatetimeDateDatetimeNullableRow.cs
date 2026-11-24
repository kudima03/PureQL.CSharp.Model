using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asDatetime.date.datetime.nullable@row</c>.</summary>
public sealed record AsDatetimeDateDatetimeNullableRow : IOperator
{
    public AsDatetimeDateDatetimeNullableRow(
        DateNullableRow operand,
        StringNullableRow? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DateNullableRow Operand { get; }

    public StringNullableRow? Zone { get; }

    public IType Type => new TypeDatetimeNullable();
}
