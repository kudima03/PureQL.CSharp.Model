using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfDatetimeProjection : IOperator
{
    public IfDatetimeProjection(
        BooleanProjection condition,
        DatetimeProjection then,
        DatetimeProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public DatetimeProjection Then { get; }

    public DatetimeProjection Else { get; }

    public IType Type => new TypeDatetime();
}
