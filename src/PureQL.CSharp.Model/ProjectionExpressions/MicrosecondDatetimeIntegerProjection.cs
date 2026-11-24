using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>microsecond.datetime.integer@projection</c>.</summary>
public sealed record MicrosecondDatetimeIntegerProjection : IOperator
{
    public MicrosecondDatetimeIntegerProjection(DatetimeProjection operand)
    {
        Operand = operand;
    }

    public DatetimeProjection Operand { get; }

    public IType Type => new TypeInteger();
}
