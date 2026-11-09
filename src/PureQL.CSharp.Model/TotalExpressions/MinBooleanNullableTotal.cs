using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>min.boolean.nullable@total</c>.</summary>
public sealed record MinBooleanNullableTotal : IOperator
{
    public MinBooleanNullableTotal(
        BooleanNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public BooleanNullableRow Selector { get; }

    public IType Type => new TypeBooleanNullable();
}
