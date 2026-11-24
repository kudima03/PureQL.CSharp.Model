using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>max.date@projection</c>.</summary>
public sealed record MaxDateProjection : IOperator
{
    public MaxDateProjection(DateRow selector, Window? over = null)
    {
        Over = over;
        Selector = selector;
    }

    public Window? Over { get; }

    public DateRow Selector { get; }

    public IType Type => new TypeDate();
}
