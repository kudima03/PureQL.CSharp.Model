using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>week.datetime.integer@projection</c>.</summary>
public sealed record WeekDatetimeIntegerProjection : IOperator
{
    public WeekDatetimeIntegerProjection(
        DatetimeProjection operand,
        StringProjection? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeProjection Operand { get; }

    public StringProjection? Zone { get; }

    public IType Type => new TypeInteger();
}
