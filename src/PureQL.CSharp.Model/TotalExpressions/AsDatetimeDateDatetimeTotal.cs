using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asDatetime.date.datetime@total</c>.</summary>
public sealed record AsDatetimeDateDatetimeTotal : IOperator
{
    public AsDatetimeDateDatetimeTotal(DateTotal operand, StringTotal? zone = null)
    {
        Operand = operand;
        Zone = zone;
    }

    public DateTotal Operand { get; }

    public StringTotal? Zone { get; }

    public IType Type => new TypeDatetime();
}
