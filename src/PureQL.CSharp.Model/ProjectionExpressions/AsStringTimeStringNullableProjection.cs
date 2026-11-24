using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asString.time.string.nullable@projection</c>.</summary>
public sealed record AsStringTimeStringNullableProjection : IOperator
{
    public AsStringTimeStringNullableProjection(DeclaresTimeNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableProjection Operand { get; }

    public IType Type => new TypeStringNullable();
}
