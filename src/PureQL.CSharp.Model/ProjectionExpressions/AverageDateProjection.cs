using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>average.date@projection</c>.</summary>
public sealed record AverageDateProjection : IOperator
{
    public AverageDateProjection(DateRow selector, Window? over = null)
    {
        Over = over;
        Selector = selector;
    }

    public Window? Over { get; }

    public DateRow Selector { get; }

    public IType Type => new TypeDate();
}
