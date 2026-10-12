using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record MinStringNullableTotal : IOperator
{
    public MinStringNullableTotal(
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
