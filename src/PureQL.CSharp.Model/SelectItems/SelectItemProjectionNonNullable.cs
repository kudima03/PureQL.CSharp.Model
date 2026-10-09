using OneOf;

namespace PureQL.CSharp.Model.SelectItems;

public sealed class SelectItemProjectionNonNullable
    : OneOfBase<
        SelectItemProjectionInteger,
        SelectItemProjectionDecimal,
        SelectItemProjectionString,
        SelectItemProjectionBoolean,
        SelectItemProjectionDate,
        SelectItemProjectionTime,
        SelectItemProjectionDatetime,
        SelectItemProjectionUuid
    >
{
    public SelectItemProjectionNonNullable(SelectItemProjectionInteger value)
        : this(
            (OneOf<
                SelectItemProjectionInteger,
                SelectItemProjectionDecimal,
                SelectItemProjectionString,
                SelectItemProjectionBoolean,
                SelectItemProjectionDate,
                SelectItemProjectionTime,
                SelectItemProjectionDatetime,
                SelectItemProjectionUuid
            >)
                value
        )
    { }

    public SelectItemProjectionNonNullable(SelectItemProjectionDecimal value)
        : this(
            (OneOf<
                SelectItemProjectionInteger,
                SelectItemProjectionDecimal,
                SelectItemProjectionString,
                SelectItemProjectionBoolean,
                SelectItemProjectionDate,
                SelectItemProjectionTime,
                SelectItemProjectionDatetime,
                SelectItemProjectionUuid
            >)
                value
        )
    { }

    public SelectItemProjectionNonNullable(SelectItemProjectionString value)
        : this(
            (OneOf<
                SelectItemProjectionInteger,
                SelectItemProjectionDecimal,
                SelectItemProjectionString,
                SelectItemProjectionBoolean,
                SelectItemProjectionDate,
                SelectItemProjectionTime,
                SelectItemProjectionDatetime,
                SelectItemProjectionUuid
            >)
                value
        )
    { }

    public SelectItemProjectionNonNullable(SelectItemProjectionBoolean value)
        : this(
            (OneOf<
                SelectItemProjectionInteger,
                SelectItemProjectionDecimal,
                SelectItemProjectionString,
                SelectItemProjectionBoolean,
                SelectItemProjectionDate,
                SelectItemProjectionTime,
                SelectItemProjectionDatetime,
                SelectItemProjectionUuid
            >)
                value
        )
    { }

    public SelectItemProjectionNonNullable(SelectItemProjectionDate value)
        : this(
            (OneOf<
                SelectItemProjectionInteger,
                SelectItemProjectionDecimal,
                SelectItemProjectionString,
                SelectItemProjectionBoolean,
                SelectItemProjectionDate,
                SelectItemProjectionTime,
                SelectItemProjectionDatetime,
                SelectItemProjectionUuid
            >)
                value
        )
    { }

    public SelectItemProjectionNonNullable(SelectItemProjectionTime value)
        : this(
            (OneOf<
                SelectItemProjectionInteger,
                SelectItemProjectionDecimal,
                SelectItemProjectionString,
                SelectItemProjectionBoolean,
                SelectItemProjectionDate,
                SelectItemProjectionTime,
                SelectItemProjectionDatetime,
                SelectItemProjectionUuid
            >)
                value
        )
    { }

    public SelectItemProjectionNonNullable(SelectItemProjectionDatetime value)
        : this(
            (OneOf<
                SelectItemProjectionInteger,
                SelectItemProjectionDecimal,
                SelectItemProjectionString,
                SelectItemProjectionBoolean,
                SelectItemProjectionDate,
                SelectItemProjectionTime,
                SelectItemProjectionDatetime,
                SelectItemProjectionUuid
            >)
                value
        )
    { }

    public SelectItemProjectionNonNullable(SelectItemProjectionUuid value)
        : this(
            (OneOf<
                SelectItemProjectionInteger,
                SelectItemProjectionDecimal,
                SelectItemProjectionString,
                SelectItemProjectionBoolean,
                SelectItemProjectionDate,
                SelectItemProjectionTime,
                SelectItemProjectionDatetime,
                SelectItemProjectionUuid
            >)
                value
        )
    { }

    private SelectItemProjectionNonNullable(
        OneOf<
            SelectItemProjectionInteger,
            SelectItemProjectionDecimal,
            SelectItemProjectionString,
            SelectItemProjectionBoolean,
            SelectItemProjectionDate,
            SelectItemProjectionTime,
            SelectItemProjectionDatetime,
            SelectItemProjectionUuid
        > input
    )
        : base(input) { }
}
