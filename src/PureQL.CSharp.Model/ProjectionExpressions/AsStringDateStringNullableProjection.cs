using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asString.date.string.nullable@projection</c>.</summary>
public sealed record AsStringDateStringNullableProjection : IOperator
{
    public AsStringDateStringNullableProjection(DeclaresDateNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableProjection Operand { get; }

    public IType Type => new TypeStringNullable();
}
