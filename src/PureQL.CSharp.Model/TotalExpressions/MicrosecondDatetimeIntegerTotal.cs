using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>microsecond.datetime.integer@total</c>.</summary>
public sealed record MicrosecondDatetimeIntegerTotal : IOperator
{
    public MicrosecondDatetimeIntegerTotal(DatetimeTotal operand)
    {
        Operand = operand;
    }

    public DatetimeTotal Operand { get; }

    public IType Type => new TypeInteger();
}
