using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asDate.datetime.date@projection</c>.</summary>
public sealed record AsDateDatetimeDateProjection : IOperator
{
    public AsDateDatetimeDateProjection(
        DatetimeProjection operand,
        StringProjection? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeProjection Operand { get; }

    public StringProjection? Zone { get; }

    public IType Type => new TypeDate();
}
