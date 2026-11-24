using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>mode.uuid.nullable@total</c>.</summary>
public sealed record ModeUuidNullableTotal : IOperator
{
    public ModeUuidNullableTotal(UuidNullableRow selector, BooleanRow? predicate = null)
    {
        Predicate = predicate;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public UuidNullableRow Selector { get; }

    public IType Type => new TypeUuidNullable();
}
