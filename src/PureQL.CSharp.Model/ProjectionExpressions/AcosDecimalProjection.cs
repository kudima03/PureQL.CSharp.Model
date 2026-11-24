using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>acos.decimal@projection</c>.</summary>
public sealed record AcosDecimalProjection : IOperator
{
    public AcosDecimalProjection(DecimalProjection operand)
    {
        Operand = operand;
    }

    public DecimalProjection Operand { get; }

    public IType Type => new TypeDecimal();
}
