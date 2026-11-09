using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>max.date.nullable@projection</c>.</summary>
public sealed record MaxDateNullableProjection : IOperator
{
    public MaxDateNullableProjection(
        DateNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public DateNullableRow Selector { get; }

    public IType Type => new TypeDateNullable();
}
