using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>sqrt.decimal@projection</c>.</summary>
public sealed record SqrtDecimalProjection : IOperator
{
    public SqrtDecimalProjection(DecimalProjection operand)
    {
        Operand = operand;
    }

    public DecimalProjection Operand { get; }

    public IType Type => new TypeDecimal();
}
