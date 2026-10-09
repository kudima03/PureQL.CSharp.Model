using OneOf;

namespace PureQL.CSharp.Model.SelectItems;

public sealed class SelectItemProjectionNullable
    : OneOfBase<
        SelectItemProjectionIntegerNullable,
        SelectItemProjectionDecimalNullable,
        SelectItemProjectionStringNullable,
        SelectItemProjectionBooleanNullable,
        SelectItemProjectionDateNullable,
        SelectItemProjectionTimeNullable,
        SelectItemProjectionDatetimeNullable,
        SelectItemProjectionUuidNullable
    >
{
    public SelectItemProjectionNullable(SelectItemProjectionIntegerNullable value)
        : this(
            (OneOf<
                SelectItemProjectionIntegerNullable,
                SelectItemProjectionDecimalNullable,
                SelectItemProjectionStringNullable,
                SelectItemProjectionBooleanNullable,
                SelectItemProjectionDateNullable,
                SelectItemProjectionTimeNullable,
                SelectItemProjectionDatetimeNullable,
                SelectItemProjectionUuidNullable
            >)
                value
        )
    { }

    public SelectItemProjectionNullable(SelectItemProjectionDecimalNullable value)
        : this(
            (OneOf<
                SelectItemProjectionIntegerNullable,
                SelectItemProjectionDecimalNullable,
                SelectItemProjectionStringNullable,
                SelectItemProjectionBooleanNullable,
                SelectItemProjectionDateNullable,
                SelectItemProjectionTimeNullable,
                SelectItemProjectionDatetimeNullable,
                SelectItemProjectionUuidNullable
            >)
                value
        )
    { }

    public SelectItemProjectionNullable(SelectItemProjectionStringNullable value)
        : this(
            (OneOf<
                SelectItemProjectionIntegerNullable,
                SelectItemProjectionDecimalNullable,
                SelectItemProjectionStringNullable,
                SelectItemProjectionBooleanNullable,
                SelectItemProjectionDateNullable,
                SelectItemProjectionTimeNullable,
                SelectItemProjectionDatetimeNullable,
                SelectItemProjectionUuidNullable
            >)
                value
        )
    { }

    public SelectItemProjectionNullable(SelectItemProjectionBooleanNullable value)
        : this(
            (OneOf<
                SelectItemProjectionIntegerNullable,
                SelectItemProjectionDecimalNullable,
                SelectItemProjectionStringNullable,
                SelectItemProjectionBooleanNullable,
                SelectItemProjectionDateNullable,
                SelectItemProjectionTimeNullable,
                SelectItemProjectionDatetimeNullable,
                SelectItemProjectionUuidNullable
            >)
                value
        )
    { }

    public SelectItemProjectionNullable(SelectItemProjectionDateNullable value)
        : this(
            (OneOf<
                SelectItemProjectionIntegerNullable,
                SelectItemProjectionDecimalNullable,
                SelectItemProjectionStringNullable,
                SelectItemProjectionBooleanNullable,
                SelectItemProjectionDateNullable,
                SelectItemProjectionTimeNullable,
                SelectItemProjectionDatetimeNullable,
                SelectItemProjectionUuidNullable
            >)
                value
        )
    { }

    public SelectItemProjectionNullable(SelectItemProjectionTimeNullable value)
        : this(
            (OneOf<
                SelectItemProjectionIntegerNullable,
                SelectItemProjectionDecimalNullable,
                SelectItemProjectionStringNullable,
                SelectItemProjectionBooleanNullable,
                SelectItemProjectionDateNullable,
                SelectItemProjectionTimeNullable,
                SelectItemProjectionDatetimeNullable,
                SelectItemProjectionUuidNullable
            >)
                value
        )
    { }

    public SelectItemProjectionNullable(SelectItemProjectionDatetimeNullable value)
        : this(
            (OneOf<
                SelectItemProjectionIntegerNullable,
                SelectItemProjectionDecimalNullable,
                SelectItemProjectionStringNullable,
                SelectItemProjectionBooleanNullable,
                SelectItemProjectionDateNullable,
                SelectItemProjectionTimeNullable,
                SelectItemProjectionDatetimeNullable,
                SelectItemProjectionUuidNullable
            >)
                value
        )
    { }

    public SelectItemProjectionNullable(SelectItemProjectionUuidNullable value)
        : this(
            (OneOf<
                SelectItemProjectionIntegerNullable,
                SelectItemProjectionDecimalNullable,
                SelectItemProjectionStringNullable,
                SelectItemProjectionBooleanNullable,
                SelectItemProjectionDateNullable,
                SelectItemProjectionTimeNullable,
                SelectItemProjectionDatetimeNullable,
                SelectItemProjectionUuidNullable
            >)
                value
        )
    { }

    private SelectItemProjectionNullable(
        OneOf<
            SelectItemProjectionIntegerNullable,
            SelectItemProjectionDecimalNullable,
            SelectItemProjectionStringNullable,
            SelectItemProjectionBooleanNullable,
            SelectItemProjectionDateNullable,
            SelectItemProjectionTimeNullable,
            SelectItemProjectionDatetimeNullable,
            SelectItemProjectionUuidNullable
        > input
    )
        : base(input) { }
}
