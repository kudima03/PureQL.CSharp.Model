using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>min.datetime.nullable@total</c>.</summary>
public sealed record MinDatetimeNullableTotal : IOperator
{
    public MinDatetimeNullableTotal(
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
