using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record MinBooleanNullableTotal : IOperator
{
    public MinBooleanNullableTotal(
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
