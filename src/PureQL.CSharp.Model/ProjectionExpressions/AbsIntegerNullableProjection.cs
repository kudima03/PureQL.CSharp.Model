using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>abs.integer.nullable@projection</c>.</summary>
public sealed record AbsIntegerNullableProjection : IOperator
{
    public AbsIntegerNullableProjection(DeclaresIntegerNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresIntegerNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
