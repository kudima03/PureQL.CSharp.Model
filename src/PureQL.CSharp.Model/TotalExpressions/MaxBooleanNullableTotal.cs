using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record MaxBooleanNullableTotal : IOperator
{
    public MaxBooleanNullableTotal(
        BooleanNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Selector = selector;
        Predicate = predicate;
    }

    public BooleanNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }

    public IType Type => new TypeBooleanNullable();
}
