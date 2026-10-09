using OneOf;

namespace PureQL.CSharp.Model.SelectItems;

public sealed class SelectItemProjection
    : OneOfBase<SelectItemProjectionNonNullable, SelectItemProjectionNullable>
{
    public SelectItemProjection(SelectItemProjectionNonNullable value)
        : this(
            (OneOf<SelectItemProjectionNonNullable, SelectItemProjectionNullable>)value
        )
    { }

    public SelectItemProjection(SelectItemProjectionNullable value)
        : this(
            (OneOf<SelectItemProjectionNonNullable, SelectItemProjectionNullable>)value
        )
    { }

    private SelectItemProjection(
        OneOf<SelectItemProjectionNonNullable, SelectItemProjectionNullable> input
    )
        : base(input) { }
}
