using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>max.uuid.nullable@total</c>.</summary>
public sealed record MaxUuidNullableTotal : IOperator
{
    public MaxUuidNullableTotal(UuidNullableRow selector, BooleanRow? predicate = null)
    {
        Predicate = predicate;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public UuidNullableRow Selector { get; }

    public IType Type => new TypeUuidNullable();
}
