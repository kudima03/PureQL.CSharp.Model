using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asBoolean.boolean@projection</c>.</summary>
public sealed record AsBooleanBooleanProjection : IOperator
{
    public AsBooleanBooleanProjection(StringProjection operand)
    {
        Operand = operand;
    }

    public StringProjection Operand { get; }

    public IType Type => new TypeBoolean();
}
