using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfIntegerNullableProjection : IOperator
{
    public IfIntegerNullableProjection(
        BooleanProjection condition,
        IntegerNullableProjection then,
        IntegerNullableProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public IntegerNullableProjection Then { get; }

    public IntegerNullableProjection Else { get; }

    public IType Type => new TypeIntegerNullable();
}
