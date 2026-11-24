using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asString.boolean.string@projection</c>.</summary>
public sealed record AsStringBooleanStringProjection : IOperator
{
    public AsStringBooleanStringProjection(BooleanProjection operand)
    {
        Operand = operand;
    }

    public BooleanProjection Operand { get; }

    public IType Type => new TypeString();
}
