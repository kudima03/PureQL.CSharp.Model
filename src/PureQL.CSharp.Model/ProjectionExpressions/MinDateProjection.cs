using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>min.date@projection</c>.</summary>
public sealed record MinDateProjection : IOperator
{
    public MinDateProjection(DateRow selector)
    {
        Selector = selector;
    }

    public DateRow Selector { get; }

    public IType Type => new TypeDate();
}
