using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record MaxDateProjection : IOperator
{
    public MaxDateProjection(DateRow selector)
    {
        Selector = selector;
    }

    public DateRow Selector { get; }

    public IType Type => new TypeDate();
}
