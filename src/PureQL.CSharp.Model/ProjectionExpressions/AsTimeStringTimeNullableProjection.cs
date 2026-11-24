using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asTime.string.time.nullable@projection</c>.</summary>
public sealed record AsTimeStringTimeNullableProjection : IOperator
{
    public AsTimeStringTimeNullableProjection(DeclaresStringNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableProjection Operand { get; }

    public IType Type => new TypeTimeNullable();
}
