using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>min.time.nullable@total</c>.</summary>
public sealed record MinTimeNullableTotal : IOperator
{
    public MinTimeNullableTotal(TimeNullableRow selector, BooleanRow? predicate = null)
    {
        Predicate = predicate;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public TimeNullableRow Selector { get; }

    public IType Type => new TypeTimeNullable();
}
