using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfBooleanNullableProjection : IOperator
{
    public IfBooleanNullableProjection(
        BooleanProjection condition,
        BooleanNullableProjection then,
        BooleanNullableProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public BooleanNullableProjection Then { get; }

    public BooleanNullableProjection Else { get; }

    public IType Type => new TypeBooleanNullable();
}
