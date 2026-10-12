using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record MaxDecimalNullableTotal : IOperator
{
    public MaxDecimalNullableTotal(
        DecimalNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Selector = selector;
        Predicate = predicate;
    }

    public DecimalNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }

    public IType Type => new TypeDecimalNullable();
}
