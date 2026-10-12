using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record MaxBooleanProjection : IOperator
{
    public MaxBooleanProjection(BooleanRow selector)
    {
        Selector = selector;
    }

    public BooleanRow Selector { get; }

    public IType Type => new TypeBoolean();
}
