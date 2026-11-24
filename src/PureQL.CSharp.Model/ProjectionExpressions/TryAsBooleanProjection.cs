using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>tryAsBoolean@projection</c>.</summary>
public sealed record TryAsBooleanProjection : IOperator
{
    public TryAsBooleanProjection(StringNullableProjection operand)
    {
        Operand = operand;
    }

    public StringNullableProjection Operand { get; }

    public IType Type => new TypeBooleanNullable();
}
