using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asString.time.string@projection</c>.</summary>
public sealed record AsStringTimeStringProjection : IOperator
{
    public AsStringTimeStringProjection(TimeProjection operand)
    {
        Operand = operand;
    }

    public TimeProjection Operand { get; }

    public IType Type => new TypeString();
}
