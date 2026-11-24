using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asString.uuid.string@projection</c>.</summary>
public sealed record AsStringUuidStringProjection : IOperator
{
    public AsStringUuidStringProjection(UuidProjection operand)
    {
        Operand = operand;
    }

    public UuidProjection Operand { get; }

    public IType Type => new TypeString();
}
