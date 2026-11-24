using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asDatetime.date.datetime@row</c>.</summary>
public sealed record AsDatetimeDateDatetimeRow : IOperator
{
    public AsDatetimeDateDatetimeRow(DateRow operand, StringRow? zone = null)
    {
        Operand = operand;
        Zone = zone;
    }

    public DateRow Operand { get; }

    public StringRow? Zone { get; }

    public IType Type => new TypeDatetime();
}
