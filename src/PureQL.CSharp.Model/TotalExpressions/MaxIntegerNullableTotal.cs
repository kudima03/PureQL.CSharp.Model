using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record MaxIntegerNullableTotal : IOperator
{
    public MaxIntegerNullableTotal(
        IntegerNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Selector = selector;
        Predicate = predicate;
    }

    public IntegerNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }

    public IType Type => new TypeIntegerNullable();
}
