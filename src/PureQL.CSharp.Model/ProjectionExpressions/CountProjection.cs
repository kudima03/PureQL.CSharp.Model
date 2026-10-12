using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CountProjection : IOperator
{
    public CountProjection(BooleanRow? predicate = null)
    {
        Predicate = predicate;
    }

    public BooleanRow? Predicate { get; }

    public IType Type => new TypeInteger();
}
