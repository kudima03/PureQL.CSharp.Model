using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record MinTimeNullableTotal : IOperator
{
    public MinTimeNullableTotal(TimeNullableRow selector, BooleanRow? predicate = null)
    {
        Selector = selector;
        Predicate = predicate;
    }

    public TimeNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }

    public IType Type => new TypeTimeNullable();
}
