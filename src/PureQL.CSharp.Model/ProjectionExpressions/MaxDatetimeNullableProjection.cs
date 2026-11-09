using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>max.datetime.nullable@projection</c>.</summary>
public sealed record MaxDatetimeNullableProjection : IOperator
{
    public MaxDatetimeNullableProjection(
        DatetimeNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public DatetimeNullableRow Selector { get; }

    public IType Type => new TypeDatetimeNullable();
}
