using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfTimeNullableProjection : IOperator
{
    public IfTimeNullableProjection(
        BooleanProjection condition,
        TimeNullableProjection then,
        TimeNullableProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public TimeNullableProjection Then { get; }

    public TimeNullableProjection Else { get; }

    public IType Type => new TypeTimeNullable();
}
