using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>startOfSecond.datetime@projection</c>.</summary>
public sealed record StartOfSecondDatetimeProjection : IOperator
{
    public StartOfSecondDatetimeProjection(DatetimeProjection operand)
    {
        Operand = operand;
    }

    public DatetimeProjection Operand { get; }

    public IType Type => new TypeDatetime();
}
