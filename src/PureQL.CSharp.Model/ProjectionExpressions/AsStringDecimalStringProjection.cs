using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asString.decimal.string@projection</c>.</summary>
public sealed record AsStringDecimalStringProjection : IOperator
{
    public AsStringDecimalStringProjection(DecimalProjection operand)
    {
        Operand = operand;
    }

    public DecimalProjection Operand { get; }

    public IType Type => new TypeString();
}
