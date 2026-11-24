using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>startOfSecond.datetime@total</c>.</summary>
public sealed record StartOfSecondDatetimeTotal : IOperator
{
    public StartOfSecondDatetimeTotal(DatetimeTotal operand)
    {
        Operand = operand;
    }

    public DatetimeTotal Operand { get; }

    public IType Type => new TypeDatetime();
}
