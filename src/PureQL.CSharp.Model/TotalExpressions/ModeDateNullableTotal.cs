using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>mode.date.nullable@total</c>.</summary>
public sealed record ModeDateNullableTotal : IOperator
{
    public ModeDateNullableTotal(DateNullableRow selector, BooleanRow? predicate = null)
    {
        Predicate = predicate;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public DateNullableRow Selector { get; }

    public IType Type => new TypeDateNullable();
}
