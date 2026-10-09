using OneOf;

namespace PureQL.CSharp.Model.SelectItems;

public sealed class SelectItemGroupNonNullable
    : OneOfBase<
        SelectItemGroupInteger,
        SelectItemGroupDecimal,
        SelectItemGroupString,
        SelectItemGroupBoolean,
        SelectItemGroupDate,
        SelectItemGroupTime,
        SelectItemGroupDatetime,
        SelectItemGroupUuid
    >
{
    public SelectItemGroupNonNullable(SelectItemGroupInteger value)
        : this(
            (OneOf<
                SelectItemGroupInteger,
                SelectItemGroupDecimal,
                SelectItemGroupString,
                SelectItemGroupBoolean,
                SelectItemGroupDate,
                SelectItemGroupTime,
                SelectItemGroupDatetime,
                SelectItemGroupUuid
            >)
                value
        )
    { }

    public SelectItemGroupNonNullable(SelectItemGroupDecimal value)
        : this(
            (OneOf<
                SelectItemGroupInteger,
                SelectItemGroupDecimal,
                SelectItemGroupString,
                SelectItemGroupBoolean,
                SelectItemGroupDate,
                SelectItemGroupTime,
                SelectItemGroupDatetime,
                SelectItemGroupUuid
            >)
                value
        )
    { }

    public SelectItemGroupNonNullable(SelectItemGroupString value)
        : this(
            (OneOf<
                SelectItemGroupInteger,
                SelectItemGroupDecimal,
                SelectItemGroupString,
                SelectItemGroupBoolean,
                SelectItemGroupDate,
                SelectItemGroupTime,
                SelectItemGroupDatetime,
                SelectItemGroupUuid
            >)
                value
        )
    { }

    public SelectItemGroupNonNullable(SelectItemGroupBoolean value)
        : this(
            (OneOf<
                SelectItemGroupInteger,
                SelectItemGroupDecimal,
                SelectItemGroupString,
                SelectItemGroupBoolean,
                SelectItemGroupDate,
                SelectItemGroupTime,
                SelectItemGroupDatetime,
                SelectItemGroupUuid
            >)
                value
        )
    { }

    public SelectItemGroupNonNullable(SelectItemGroupDate value)
        : this(
            (OneOf<
                SelectItemGroupInteger,
                SelectItemGroupDecimal,
                SelectItemGroupString,
                SelectItemGroupBoolean,
                SelectItemGroupDate,
                SelectItemGroupTime,
                SelectItemGroupDatetime,
                SelectItemGroupUuid
            >)
                value
        )
    { }

    public SelectItemGroupNonNullable(SelectItemGroupTime value)
        : this(
            (OneOf<
                SelectItemGroupInteger,
                SelectItemGroupDecimal,
                SelectItemGroupString,
                SelectItemGroupBoolean,
                SelectItemGroupDate,
                SelectItemGroupTime,
                SelectItemGroupDatetime,
                SelectItemGroupUuid
            >)
                value
        )
    { }

    public SelectItemGroupNonNullable(SelectItemGroupDatetime value)
        : this(
            (OneOf<
                SelectItemGroupInteger,
                SelectItemGroupDecimal,
                SelectItemGroupString,
                SelectItemGroupBoolean,
                SelectItemGroupDate,
                SelectItemGroupTime,
                SelectItemGroupDatetime,
                SelectItemGroupUuid
            >)
                value
        )
    { }

    public SelectItemGroupNonNullable(SelectItemGroupUuid value)
        : this(
            (OneOf<
                SelectItemGroupInteger,
                SelectItemGroupDecimal,
                SelectItemGroupString,
                SelectItemGroupBoolean,
                SelectItemGroupDate,
                SelectItemGroupTime,
                SelectItemGroupDatetime,
                SelectItemGroupUuid
            >)
                value
        )
    { }

    private SelectItemGroupNonNullable(
        OneOf<
            SelectItemGroupInteger,
            SelectItemGroupDecimal,
            SelectItemGroupString,
            SelectItemGroupBoolean,
            SelectItemGroupDate,
            SelectItemGroupTime,
            SelectItemGroupDatetime,
            SelectItemGroupUuid
        > input
    )
        : base(input) { }
}
