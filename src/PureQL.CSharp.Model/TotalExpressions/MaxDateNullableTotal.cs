using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>max.date.nullable@total</c>.</summary>
public sealed record MaxDateNullableTotal : IOperator
{
    public MaxDateNullableTotal(DateNullableRow selector, BooleanRow? predicate = null)
    {
        Predicate = predicate;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public DateNullableRow Selector { get; }

    public IType Type => new TypeDateNullable();
}
