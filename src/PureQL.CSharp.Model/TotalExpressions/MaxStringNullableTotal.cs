using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>max.string.nullable@total</c>.</summary>
public sealed record MaxStringNullableTotal : IOperator
{
    public MaxStringNullableTotal(
        StringNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public StringNullableRow Selector { get; }

    public IType Type => new TypeStringNullable();
}
