using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record AverageDateProjection : IOperator
{
    public AverageDateProjection(DateRow selector)
    {
        Selector = selector;
    }

    public DateRow Selector { get; }

    public IType Type => new TypeDate();
}
