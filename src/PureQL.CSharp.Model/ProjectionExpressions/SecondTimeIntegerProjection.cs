using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>second.time.integer@projection</c>.</summary>
public sealed record SecondTimeIntegerProjection : IOperator
{
    public SecondTimeIntegerProjection(TimeProjection operand)
    {
        Operand = operand;
    }

    public TimeProjection Operand { get; }

    public IType Type => new TypeInteger();
}
