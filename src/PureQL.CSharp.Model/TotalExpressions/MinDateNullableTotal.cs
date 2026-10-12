using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record MinDateNullableTotal : IOperator
{
    public MinDateNullableTotal(DateNullableRow selector, BooleanRow? predicate = null)
    {
        Selector = selector;
        Predicate = predicate;
    }

    public DateNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }

    public IType Type => new TypeDateNullable();
}
