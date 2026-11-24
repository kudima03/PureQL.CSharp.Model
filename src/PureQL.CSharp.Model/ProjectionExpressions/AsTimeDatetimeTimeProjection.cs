using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asTime.datetime.time@projection</c>.</summary>
public sealed record AsTimeDatetimeTimeProjection : IOperator
{
    public AsTimeDatetimeTimeProjection(
        DatetimeProjection operand,
        StringProjection? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeProjection Operand { get; }

    public StringProjection? Zone { get; }

    public IType Type => new TypeTime();
}
