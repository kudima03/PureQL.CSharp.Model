using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asTime.datetime.time@total</c>.</summary>
public sealed record AsTimeDatetimeTimeTotal : IOperator
{
    public AsTimeDatetimeTimeTotal(DatetimeTotal operand, StringTotal? zone = null)
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeTotal Operand { get; }

    public StringTotal? Zone { get; }

    public IType Type => new TypeTime();
}
