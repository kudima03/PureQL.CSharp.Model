using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>max.datetime@projection</c>.</summary>
public sealed record MaxDatetimeProjection : IOperator
{
    public MaxDatetimeProjection(DatetimeRow selector)
    {
        Selector = selector;
    }

    public DatetimeRow Selector { get; }

    public IType Type => new TypeDatetime();
}
