using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record AverageDatetimeNullableProjection : IOperator
{
    public AverageDatetimeNullableProjection(
        DatetimeNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Selector = selector;
        Predicate = predicate;
    }

    public DatetimeNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }

    public IType Type => new TypeDatetimeNullable();
}
