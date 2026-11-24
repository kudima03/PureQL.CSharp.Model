using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>abs.decimal.nullable@projection</c>.</summary>
public sealed record AbsDecimalNullableProjection : IOperator
{
    public AbsDecimalNullableProjection(DeclaresDecimalNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalNullableProjection Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
