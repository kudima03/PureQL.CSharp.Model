using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record MinStringProjection : IOperator
{
    public MinStringProjection(StringRow selector)
    {
        Selector = selector;
    }

    public StringRow Selector { get; }

    public IType Type => new TypeString();
}
