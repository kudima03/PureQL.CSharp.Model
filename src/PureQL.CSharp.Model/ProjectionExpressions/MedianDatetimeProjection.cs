using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>median.datetime@projection</c>.</summary>
public sealed record MedianDatetimeProjection : IOperator
{
    public MedianDatetimeProjection(DatetimeRow selector, Window? over = null)
    {
        Over = over;
        Selector = selector;
    }

    public Window? Over { get; }

    public DatetimeRow Selector { get; }

    public IType Type => new TypeDatetime();
}
