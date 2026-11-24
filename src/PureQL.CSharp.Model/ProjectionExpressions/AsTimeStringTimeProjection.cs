using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asTime.string.time@projection</c>.</summary>
public sealed record AsTimeStringTimeProjection : IOperator
{
    public AsTimeStringTimeProjection(StringProjection operand)
    {
        Operand = operand;
    }

    public StringProjection Operand { get; }

    public IType Type => new TypeTime();
}
