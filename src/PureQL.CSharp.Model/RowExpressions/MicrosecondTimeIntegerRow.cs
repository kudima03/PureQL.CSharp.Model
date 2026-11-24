using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>microsecond.time.integer@row</c>.</summary>
public sealed record MicrosecondTimeIntegerRow : IOperator
{
    public MicrosecondTimeIntegerRow(TimeRow operand)
    {
        Operand = operand;
    }

    public TimeRow Operand { get; }

    public IType Type => new TypeInteger();
}
