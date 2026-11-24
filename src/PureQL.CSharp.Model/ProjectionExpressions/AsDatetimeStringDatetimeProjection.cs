using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asDatetime.string.datetime@projection</c>.</summary>
public sealed record AsDatetimeStringDatetimeProjection : IOperator
{
    public AsDatetimeStringDatetimeProjection(StringProjection operand)
    {
        Operand = operand;
    }

    public StringProjection Operand { get; }

    public IType Type => new TypeDatetime();
}
