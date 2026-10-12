using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record SumIntegerTotal : IOperator
{
    public SumIntegerTotal(IntegerNullableRow selector, BooleanRow? predicate = null)
    {
        Selector = selector;
        Predicate = predicate;
    }

    public IntegerNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }

    public IType Type => new TypeInteger();
}
