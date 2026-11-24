using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>microsecond.time.integer@projection</c>.</summary>
public sealed record MicrosecondTimeIntegerProjection : IOperator
{
    public MicrosecondTimeIntegerProjection(TimeProjection operand)
    {
        Operand = operand;
    }

    public TimeProjection Operand { get; }

    public IType Type => new TypeInteger();
}
