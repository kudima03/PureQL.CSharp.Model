using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asDatetime.date.datetime@projection</c>.</summary>
public sealed record AsDatetimeDateDatetimeProjection : IOperator
{
    public AsDatetimeDateDatetimeProjection(
        DateProjection operand,
        StringProjection? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DateProjection Operand { get; }

    public StringProjection? Zone { get; }

    public IType Type => new TypeDatetime();
}
