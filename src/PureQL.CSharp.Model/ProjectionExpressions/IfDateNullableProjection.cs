using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>if.date.nullable@projection</c>.</summary>
public sealed record IfDateNullableProjection : IOperator
{
    public IfDateNullableProjection(
        DateNullableProjection then,
        DateNullableProjection @else,
        BooleanProjection condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DateNullableProjection Then { get; }

    public DateNullableProjection Else { get; }

    public BooleanProjection Condition { get; }

    public IType Type => new TypeDateNullable();
}
