using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>if.boolean.nullable@projection</c>.</summary>
public sealed record IfBooleanNullableProjection : IOperator
{
    public IfBooleanNullableProjection(
        BooleanNullableProjection then,
        BooleanNullableProjection @else,
        BooleanProjection condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public BooleanNullableProjection Then { get; }

    public BooleanNullableProjection Else { get; }

    public BooleanProjection Condition { get; }

    public IType Type => new TypeBooleanNullable();
}
