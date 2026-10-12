using OneOf;

namespace PureQL.CSharp.Model.SelectItems;

public sealed class SelectItemTotal
    : OneOfBase<SelectItemTotalNonNullable, SelectItemTotalNullable>
{
    public SelectItemTotal(SelectItemTotalNonNullable value)
        : this((OneOf<SelectItemTotalNonNullable, SelectItemTotalNullable>)value) { }

    public SelectItemTotal(SelectItemTotalNullable value)
        : this((OneOf<SelectItemTotalNonNullable, SelectItemTotalNullable>)value) { }

    private SelectItemTotal(
        OneOf<SelectItemTotalNonNullable, SelectItemTotalNullable> input
    )
        : base(input) { }
}
