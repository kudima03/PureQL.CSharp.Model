using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asString.datetime.string@projection</c>.</summary>
public sealed record AsStringDatetimeStringProjection : IOperator
{
    public AsStringDatetimeStringProjection(DatetimeProjection operand)
    {
        Operand = operand;
    }

    public DatetimeProjection Operand { get; }

    public IType Type => new TypeString();
}
