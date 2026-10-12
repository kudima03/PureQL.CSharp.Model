using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record AverageDatetimeProjection : IOperator
{
    public AverageDatetimeProjection(DatetimeRow selector)
    {
        Selector = selector;
    }

    public DatetimeRow Selector { get; }

    public IType Type => new TypeDatetime();
}
