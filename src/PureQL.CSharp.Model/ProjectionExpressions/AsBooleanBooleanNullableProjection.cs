using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asBoolean.boolean.nullable@projection</c>.</summary>
public sealed record AsBooleanBooleanNullableProjection : IOperator
{
    public AsBooleanBooleanNullableProjection(DeclaresStringNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableProjection Operand { get; }

    public IType Type => new TypeBooleanNullable();
}
