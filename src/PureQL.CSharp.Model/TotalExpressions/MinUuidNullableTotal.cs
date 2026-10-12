using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record MinUuidNullableTotal : IOperator
{
    public MinUuidNullableTotal(UuidNullableRow selector, BooleanRow? predicate = null)
    {
        Selector = selector;
        Predicate = predicate;
    }

    public UuidNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }

    public IType Type => new TypeUuidNullable();
}
