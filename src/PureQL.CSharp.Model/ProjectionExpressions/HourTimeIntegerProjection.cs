using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>hour.time.integer@projection</c>.</summary>
public sealed record HourTimeIntegerProjection : IOperator
{
    public HourTimeIntegerProjection(TimeProjection operand)
    {
        Operand = operand;
    }

    public TimeProjection Operand { get; }

    public IType Type => new TypeInteger();
}
