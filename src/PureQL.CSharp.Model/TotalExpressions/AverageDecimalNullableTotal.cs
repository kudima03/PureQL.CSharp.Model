using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record AverageDecimalNullableTotal : IOperator
{
    public AverageDecimalNullableTotal(
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
