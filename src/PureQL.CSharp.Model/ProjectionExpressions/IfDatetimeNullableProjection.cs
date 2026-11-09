using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>if.datetime.nullable@projection</c>.</summary>
public sealed record IfDatetimeNullableProjection : IOperator
{
    public IfDatetimeNullableProjection(
        DatetimeNullableProjection then,
        DatetimeNullableProjection @else,
        BooleanProjection condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DatetimeNullableProjection Then { get; }

    public DatetimeNullableProjection Else { get; }

    public BooleanProjection Condition { get; }

    public IType Type => new TypeDatetimeNullable();
}
