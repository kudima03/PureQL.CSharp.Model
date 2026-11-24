using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>startOfHour.time@projection</c>.</summary>
public sealed record StartOfHourTimeProjection : IOperator
{
    public StartOfHourTimeProjection(TimeProjection operand)
    {
        Operand = operand;
    }

    public TimeProjection Operand { get; }

    public IType Type => new TypeTime();
}
