using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asDate.datetime.date.nullable@row</c>.</summary>
public sealed record AsDateDatetimeDateNullableRow : IOperator
{
    public AsDateDatetimeDateNullableRow(
        DatetimeNullableRow operand,
        StringNullableRow? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeNullableRow Operand { get; }

    public StringNullableRow? Zone { get; }

    public IType Type => new TypeDateNullable();
}
