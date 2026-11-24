using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asString.datetime.string.nullable@projection</c>.</summary>
public sealed record AsStringDatetimeStringNullableProjection : IOperator
{
    public AsStringDatetimeStringNullableProjection(
        DeclaresDatetimeNullableProjection operand
    )
    {
        Operand = operand;
    }

    public DeclaresDatetimeNullableProjection Operand { get; }

    public IType Type => new TypeStringNullable();
}
