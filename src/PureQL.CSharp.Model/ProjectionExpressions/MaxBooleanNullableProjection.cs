using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>max.boolean.nullable@projection</c>.</summary>
public sealed record MaxBooleanNullableProjection : IOperator
{
    public MaxBooleanNullableProjection(
        BooleanNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public BooleanNullableRow Selector { get; }

    public IType Type => new TypeBooleanNullable();
}
