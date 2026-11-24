using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asString.date.string@projection</c>.</summary>
public sealed record AsStringDateStringProjection : IOperator
{
    public AsStringDateStringProjection(DateProjection operand)
    {
        Operand = operand;
    }

    public DateProjection Operand { get; }

    public IType Type => new TypeString();
}
