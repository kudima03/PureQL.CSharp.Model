using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asString.boolean.string.nullable@projection</c>.</summary>
public sealed record AsStringBooleanStringNullableProjection : IOperator
{
    public AsStringBooleanStringNullableProjection(
        DeclaresBooleanNullableProjection operand
    )
    {
        Operand = operand;
    }

    public DeclaresBooleanNullableProjection Operand { get; }

    public IType Type => new TypeStringNullable();
}
