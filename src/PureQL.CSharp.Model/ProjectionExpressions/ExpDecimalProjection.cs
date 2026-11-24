using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>exp.decimal@projection</c>.</summary>
public sealed record ExpDecimalProjection : IOperator
{
    public ExpDecimalProjection(DecimalProjection operand)
    {
        Operand = operand;
    }

    public DecimalProjection Operand { get; }

    public IType Type => new TypeDecimal();
}
