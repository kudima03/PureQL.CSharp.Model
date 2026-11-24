using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>median.date@projection</c>.</summary>
public sealed record MedianDateProjection : IOperator
{
    public MedianDateProjection(DateRow selector, Window? over = null)
    {
        Over = over;
        Selector = selector;
    }

    public Window? Over { get; }

    public DateRow Selector { get; }

    public IType Type => new TypeDate();
}
