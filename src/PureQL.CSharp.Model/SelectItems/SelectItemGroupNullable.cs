using OneOf;

namespace PureQL.CSharp.Model.SelectItems;

public sealed class SelectItemGroupNullable
    : OneOfBase<
        SelectItemGroupIntegerNullable,
        SelectItemGroupDecimalNullable,
        SelectItemGroupStringNullable,
        SelectItemGroupBooleanNullable,
        SelectItemGroupDateNullable,
        SelectItemGroupTimeNullable,
        SelectItemGroupDatetimeNullable,
        SelectItemGroupUuidNullable
    >
{
    public SelectItemGroupNullable(SelectItemGroupIntegerNullable value)
        : this(
            (OneOf<
                SelectItemGroupIntegerNullable,
                SelectItemGroupDecimalNullable,
                SelectItemGroupStringNullable,
                SelectItemGroupBooleanNullable,
                SelectItemGroupDateNullable,
                SelectItemGroupTimeNullable,
                SelectItemGroupDatetimeNullable,
                SelectItemGroupUuidNullable
            >)
                value
        )
    { }

    public SelectItemGroupNullable(SelectItemGroupDecimalNullable value)
        : this(
            (OneOf<
                SelectItemGroupIntegerNullable,
                SelectItemGroupDecimalNullable,
                SelectItemGroupStringNullable,
                SelectItemGroupBooleanNullable,
                SelectItemGroupDateNullable,
                SelectItemGroupTimeNullable,
                SelectItemGroupDatetimeNullable,
                SelectItemGroupUuidNullable
            >)
                value
        )
    { }

    public SelectItemGroupNullable(SelectItemGroupStringNullable value)
        : this(
            (OneOf<
                SelectItemGroupIntegerNullable,
                SelectItemGroupDecimalNullable,
                SelectItemGroupStringNullable,
                SelectItemGroupBooleanNullable,
                SelectItemGroupDateNullable,
                SelectItemGroupTimeNullable,
                SelectItemGroupDatetimeNullable,
                SelectItemGroupUuidNullable
            >)
                value
        )
    { }

    public SelectItemGroupNullable(SelectItemGroupBooleanNullable value)
        : this(
            (OneOf<
                SelectItemGroupIntegerNullable,
                SelectItemGroupDecimalNullable,
                SelectItemGroupStringNullable,
                SelectItemGroupBooleanNullable,
                SelectItemGroupDateNullable,
                SelectItemGroupTimeNullable,
                SelectItemGroupDatetimeNullable,
                SelectItemGroupUuidNullable
            >)
                value
        )
    { }

    public SelectItemGroupNullable(SelectItemGroupDateNullable value)
        : this(
            (OneOf<
                SelectItemGroupIntegerNullable,
                SelectItemGroupDecimalNullable,
                SelectItemGroupStringNullable,
                SelectItemGroupBooleanNullable,
                SelectItemGroupDateNullable,
                SelectItemGroupTimeNullable,
                SelectItemGroupDatetimeNullable,
                SelectItemGroupUuidNullable
            >)
                value
        )
    { }

    public SelectItemGroupNullable(SelectItemGroupTimeNullable value)
        : this(
            (OneOf<
                SelectItemGroupIntegerNullable,
                SelectItemGroupDecimalNullable,
                SelectItemGroupStringNullable,
                SelectItemGroupBooleanNullable,
                SelectItemGroupDateNullable,
                SelectItemGroupTimeNullable,
                SelectItemGroupDatetimeNullable,
                SelectItemGroupUuidNullable
            >)
                value
        )
    { }

    public SelectItemGroupNullable(SelectItemGroupDatetimeNullable value)
        : this(
            (OneOf<
                SelectItemGroupIntegerNullable,
                SelectItemGroupDecimalNullable,
                SelectItemGroupStringNullable,
                SelectItemGroupBooleanNullable,
                SelectItemGroupDateNullable,
                SelectItemGroupTimeNullable,
                SelectItemGroupDatetimeNullable,
                SelectItemGroupUuidNullable
            >)
                value
        )
    { }

    public SelectItemGroupNullable(SelectItemGroupUuidNullable value)
        : this(
            (OneOf<
                SelectItemGroupIntegerNullable,
                SelectItemGroupDecimalNullable,
                SelectItemGroupStringNullable,
                SelectItemGroupBooleanNullable,
                SelectItemGroupDateNullable,
                SelectItemGroupTimeNullable,
                SelectItemGroupDatetimeNullable,
                SelectItemGroupUuidNullable
            >)
                value
        )
    { }

    private SelectItemGroupNullable(
        OneOf<
            SelectItemGroupIntegerNullable,
            SelectItemGroupDecimalNullable,
            SelectItemGroupStringNullable,
            SelectItemGroupBooleanNullable,
            SelectItemGroupDateNullable,
            SelectItemGroupTimeNullable,
            SelectItemGroupDatetimeNullable,
            SelectItemGroupUuidNullable
        > input
    )
        : base(input) { }
}
