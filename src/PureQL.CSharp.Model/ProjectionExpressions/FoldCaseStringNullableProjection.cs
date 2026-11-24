using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>foldCase.string.nullable@projection</c>.</summary>
public sealed record FoldCaseStringNullableProjection : IOperator
{
    public FoldCaseStringNullableProjection(DeclaresStringNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableProjection Operand { get; }

    public IType Type => new TypeStringNullable();
}
