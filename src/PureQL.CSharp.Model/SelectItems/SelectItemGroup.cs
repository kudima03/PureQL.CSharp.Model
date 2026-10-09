using OneOf;

namespace PureQL.CSharp.Model.SelectItems;

public sealed class SelectItemGroup
    : OneOfBase<SelectItemGroupNonNullable, SelectItemGroupNullable>
{
    public SelectItemGroup(SelectItemGroupNonNullable value)
        : this((OneOf<SelectItemGroupNonNullable, SelectItemGroupNullable>)value) { }

    public SelectItemGroup(SelectItemGroupNullable value)
        : this((OneOf<SelectItemGroupNonNullable, SelectItemGroupNullable>)value) { }

    private SelectItemGroup(
        OneOf<SelectItemGroupNonNullable, SelectItemGroupNullable> input
    )
        : base(input) { }
}
