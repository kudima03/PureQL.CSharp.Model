using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asDate.datetime.date@row</c>.</summary>
public sealed record AsDateDatetimeDateRow : IOperator
{
    public AsDateDatetimeDateRow(DatetimeRow operand, StringRow? zone = null)
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeRow Operand { get; }

    public StringRow? Zone { get; }

    public IType Type => new TypeDate();
}
