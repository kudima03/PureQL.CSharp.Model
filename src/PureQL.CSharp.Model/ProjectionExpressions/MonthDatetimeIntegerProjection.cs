using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>month.datetime.integer@projection</c>.</summary>
public sealed record MonthDatetimeIntegerProjection : IOperator
{
    public MonthDatetimeIntegerProjection(
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
