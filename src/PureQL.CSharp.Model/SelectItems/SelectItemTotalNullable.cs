using OneOf;

namespace PureQL.CSharp.Model.SelectItems;

public sealed class SelectItemTotalNullable
    : OneOfBase<
        SelectItemTotalIntegerNullable,
        SelectItemTotalDecimalNullable,
        SelectItemTotalStringNullable,
        SelectItemTotalBooleanNullable,
        SelectItemTotalDateNullable,
        SelectItemTotalTimeNullable,
        SelectItemTotalDatetimeNullable,
        SelectItemTotalUuidNullable
    >
{
    public SelectItemTotalNullable(SelectItemTotalIntegerNullable value)
        : this(
            (OneOf<
                SelectItemTotalIntegerNullable,
                SelectItemTotalDecimalNullable,
                SelectItemTotalStringNullable,
                SelectItemTotalBooleanNullable,
                SelectItemTotalDateNullable,
                SelectItemTotalTimeNullable,
                SelectItemTotalDatetimeNullable,
                SelectItemTotalUuidNullable
            >)
                value
        )
    { }

    public SelectItemTotalNullable(SelectItemTotalDecimalNullable value)
        : this(
            (OneOf<
                SelectItemTotalIntegerNullable,
                SelectItemTotalDecimalNullable,
                SelectItemTotalStringNullable,
                SelectItemTotalBooleanNullable,
                SelectItemTotalDateNullable,
                SelectItemTotalTimeNullable,
                SelectItemTotalDatetimeNullable,
                SelectItemTotalUuidNullable
            >)
                value
        )
    { }

    public SelectItemTotalNullable(SelectItemTotalStringNullable value)
        : this(
            (OneOf<
                SelectItemTotalIntegerNullable,
                SelectItemTotalDecimalNullable,
                SelectItemTotalStringNullable,
                SelectItemTotalBooleanNullable,
                SelectItemTotalDateNullable,
                SelectItemTotalTimeNullable,
                SelectItemTotalDatetimeNullable,
                SelectItemTotalUuidNullable
            >)
                value
        )
    { }

    public SelectItemTotalNullable(SelectItemTotalBooleanNullable value)
        : this(
            (OneOf<
                SelectItemTotalIntegerNullable,
                SelectItemTotalDecimalNullable,
                SelectItemTotalStringNullable,
                SelectItemTotalBooleanNullable,
                SelectItemTotalDateNullable,
                SelectItemTotalTimeNullable,
                SelectItemTotalDatetimeNullable,
                SelectItemTotalUuidNullable
            >)
                value
        )
    { }

    public SelectItemTotalNullable(SelectItemTotalDateNullable value)
        : this(
            (OneOf<
                SelectItemTotalIntegerNullable,
                SelectItemTotalDecimalNullable,
                SelectItemTotalStringNullable,
                SelectItemTotalBooleanNullable,
                SelectItemTotalDateNullable,
                SelectItemTotalTimeNullable,
                SelectItemTotalDatetimeNullable,
                SelectItemTotalUuidNullable
            >)
                value
        )
    { }

    public SelectItemTotalNullable(SelectItemTotalTimeNullable value)
        : this(
            (OneOf<
                SelectItemTotalIntegerNullable,
                SelectItemTotalDecimalNullable,
                SelectItemTotalStringNullable,
                SelectItemTotalBooleanNullable,
                SelectItemTotalDateNullable,
                SelectItemTotalTimeNullable,
                SelectItemTotalDatetimeNullable,
                SelectItemTotalUuidNullable
            >)
                value
        )
    { }

    public SelectItemTotalNullable(SelectItemTotalDatetimeNullable value)
        : this(
            (OneOf<
                SelectItemTotalIntegerNullable,
                SelectItemTotalDecimalNullable,
                SelectItemTotalStringNullable,
                SelectItemTotalBooleanNullable,
                SelectItemTotalDateNullable,
                SelectItemTotalTimeNullable,
                SelectItemTotalDatetimeNullable,
                SelectItemTotalUuidNullable
            >)
                value
        )
    { }

    public SelectItemTotalNullable(SelectItemTotalUuidNullable value)
        : this(
            (OneOf<
                SelectItemTotalIntegerNullable,
                SelectItemTotalDecimalNullable,
                SelectItemTotalStringNullable,
                SelectItemTotalBooleanNullable,
                SelectItemTotalDateNullable,
                SelectItemTotalTimeNullable,
                SelectItemTotalDatetimeNullable,
                SelectItemTotalUuidNullable
            >)
                value
        )
    { }

    private SelectItemTotalNullable(
        OneOf<
            SelectItemTotalIntegerNullable,
            SelectItemTotalDecimalNullable,
            SelectItemTotalStringNullable,
            SelectItemTotalBooleanNullable,
            SelectItemTotalDateNullable,
            SelectItemTotalTimeNullable,
            SelectItemTotalDatetimeNullable,
            SelectItemTotalUuidNullable
        > input
    )
        : base(input) { }
}
