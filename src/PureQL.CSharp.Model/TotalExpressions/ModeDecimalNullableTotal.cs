using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>mode.decimal.nullable@total</c>.</summary>
public sealed record ModeDecimalNullableTotal : IOperator
{
    public ModeDecimalNullableTotal(
        DecimalOrDecimalNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public DecimalOrDecimalNullableRow Selector { get; }

    public IType Type => new TypeDecimalNullable();
}
