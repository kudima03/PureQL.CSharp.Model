using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>min.datetime@projection</c>.</summary>
public sealed record MinDatetimeProjection : IOperator
{
    public MinDatetimeProjection(DatetimeRow selector)
    {
        Selector = selector;
    }

    public DatetimeRow Selector { get; }

    public IType Type => new TypeDatetime();
}
