using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>any@projection</c>.</summary>
public sealed record AnyProjection : IOperator
{
    public AnyProjection(BooleanRow predicate)
    {
        Predicate = predicate;
    }

    public BooleanRow Predicate { get; }

    public IType Type => new TypeBoolean();
}
