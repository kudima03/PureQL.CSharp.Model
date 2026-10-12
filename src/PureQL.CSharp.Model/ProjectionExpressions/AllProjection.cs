using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record AllProjection : IOperator
{
    public AllProjection(BooleanRow predicate)
    {
        Predicate = predicate;
    }

    public BooleanRow Predicate { get; }

    public IType Type => new TypeBoolean();
}
