using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>max.datetime.nullable@total</c>.</summary>
public sealed record MaxDatetimeNullableTotal : IOperator
{
    public MaxDatetimeNullableTotal(
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
