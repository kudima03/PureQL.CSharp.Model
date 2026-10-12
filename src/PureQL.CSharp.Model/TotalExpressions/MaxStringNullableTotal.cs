using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record MaxStringNullableTotal : IOperator
{
    public MaxStringNullableTotal(
        StringNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Selector = selector;
        Predicate = predicate;
    }

    public StringNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }

    public IType Type => new TypeStringNullable();
}
