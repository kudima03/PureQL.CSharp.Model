using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asUuid.uuid@projection</c>.</summary>
public sealed record AsUuidUuidProjection : IOperator
{
    public AsUuidUuidProjection(StringProjection operand)
    {
        Operand = operand;
    }

    public StringProjection Operand { get; }

    public IType Type => new TypeUuid();
}
