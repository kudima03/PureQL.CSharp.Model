using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>microsecond.datetime.integer@row</c>.</summary>
public sealed record MicrosecondDatetimeIntegerRow : IOperator
{
    public MicrosecondDatetimeIntegerRow(DatetimeRow operand)
    {
        Operand = operand;
    }

    public DatetimeRow Operand { get; }

    public IType Type => new TypeInteger();
}
