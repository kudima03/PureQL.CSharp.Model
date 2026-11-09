using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>if.datetime@projection</c>.</summary>
public sealed record IfDatetimeProjection : IOperator
{
    public IfDatetimeProjection(
        DatetimeProjection then,
        DatetimeProjection @else,
        BooleanProjection condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DatetimeProjection Then { get; }

    public DatetimeProjection Else { get; }

    public BooleanProjection Condition { get; }

    public IType Type => new TypeDatetime();
}
