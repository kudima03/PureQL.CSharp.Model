using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asNullable.boolean.nullable@projection</c>.</summary>
public sealed record AsNullableBooleanNullableProjection : IOperator
{
    public AsNullableBooleanNullableProjection(BooleanProjection operand)
    {
        Operand = operand;
    }

    public BooleanProjection Operand { get; }

    public IType Type => new TypeBooleanNullable();
}
