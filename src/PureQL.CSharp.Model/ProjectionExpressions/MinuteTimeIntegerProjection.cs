using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>minute.time.integer@projection</c>.</summary>
public sealed record MinuteTimeIntegerProjection : IOperator
{
    public MinuteTimeIntegerProjection(TimeProjection operand)
    {
        Operand = operand;
    }

    public TimeProjection Operand { get; }

    public IType Type => new TypeInteger();
}
