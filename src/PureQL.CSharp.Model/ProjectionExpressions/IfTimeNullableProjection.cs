using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>if.time.nullable@projection</c>.</summary>
public sealed record IfTimeNullableProjection : IOperator
{
    public IfTimeNullableProjection(
        TimeNullableProjection then,
        TimeNullableProjection @else,
        BooleanProjection condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public TimeNullableProjection Then { get; }

    public TimeNullableProjection Else { get; }

    public BooleanProjection Condition { get; }

    public IType Type => new TypeTimeNullable();
}
