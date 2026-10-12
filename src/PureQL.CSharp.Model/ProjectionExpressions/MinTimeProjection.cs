using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record MinTimeProjection : IOperator
{
    public MinTimeProjection(TimeRow selector)
    {
        Selector = selector;
    }

    public TimeRow Selector { get; }

    public IType Type => new TypeTime();
}
