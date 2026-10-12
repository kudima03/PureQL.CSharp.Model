using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record MinDatetimeNullableTotal : IOperator
{
    public MinDatetimeNullableTotal(
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
