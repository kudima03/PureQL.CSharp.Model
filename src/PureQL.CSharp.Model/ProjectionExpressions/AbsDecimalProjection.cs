using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>abs.decimal@projection</c>.</summary>
public sealed record AbsDecimalProjection : IOperator
{
    public AbsDecimalProjection(DeclaresDecimalProjection operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalProjection Operand { get; }

    public IType Type => new TypeDecimal();
}
