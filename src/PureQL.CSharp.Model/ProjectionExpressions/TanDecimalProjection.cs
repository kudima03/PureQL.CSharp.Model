using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>tan.decimal@projection</c>.</summary>
public sealed record TanDecimalProjection : IOperator
{
    public TanDecimalProjection(DecimalProjection operand)
    {
        Operand = operand;
    }

    public DecimalProjection Operand { get; }

    public IType Type => new TypeDecimal();
}
