using OneOf;

namespace PureQL.CSharp.Model.SelectItems;

public sealed class SelectItemTotalNonNullable
    : OneOfBase<
        SelectItemTotalInteger,
        SelectItemTotalDecimal,
        SelectItemTotalString,
        SelectItemTotalBoolean,
        SelectItemTotalDate,
        SelectItemTotalTime,
        SelectItemTotalDatetime,
        SelectItemTotalUuid
    >
{
    public SelectItemTotalNonNullable(SelectItemTotalInteger value)
        : this(
            (OneOf<
                SelectItemTotalInteger,
                SelectItemTotalDecimal,
                SelectItemTotalString,
                SelectItemTotalBoolean,
                SelectItemTotalDate,
                SelectItemTotalTime,
                SelectItemTotalDatetime,
                SelectItemTotalUuid
            >)
                value
        )
    { }

    public SelectItemTotalNonNullable(SelectItemTotalDecimal value)
        : this(
            (OneOf<
                SelectItemTotalInteger,
                SelectItemTotalDecimal,
                SelectItemTotalString,
                SelectItemTotalBoolean,
                SelectItemTotalDate,
                SelectItemTotalTime,
                SelectItemTotalDatetime,
                SelectItemTotalUuid
            >)
                value
        )
    { }

    public SelectItemTotalNonNullable(SelectItemTotalString value)
        : this(
            (OneOf<
                SelectItemTotalInteger,
                SelectItemTotalDecimal,
                SelectItemTotalString,
                SelectItemTotalBoolean,
                SelectItemTotalDate,
                SelectItemTotalTime,
                SelectItemTotalDatetime,
                SelectItemTotalUuid
            >)
                value
        )
    { }

    public SelectItemTotalNonNullable(SelectItemTotalBoolean value)
        : this(
            (OneOf<
                SelectItemTotalInteger,
                SelectItemTotalDecimal,
                SelectItemTotalString,
                SelectItemTotalBoolean,
                SelectItemTotalDate,
                SelectItemTotalTime,
                SelectItemTotalDatetime,
                SelectItemTotalUuid
            >)
                value
        )
    { }

    public SelectItemTotalNonNullable(SelectItemTotalDate value)
        : this(
            (OneOf<
                SelectItemTotalInteger,
                SelectItemTotalDecimal,
                SelectItemTotalString,
                SelectItemTotalBoolean,
                SelectItemTotalDate,
                SelectItemTotalTime,
                SelectItemTotalDatetime,
                SelectItemTotalUuid
            >)
                value
        )
    { }

    public SelectItemTotalNonNullable(SelectItemTotalTime value)
        : this(
            (OneOf<
                SelectItemTotalInteger,
                SelectItemTotalDecimal,
                SelectItemTotalString,
                SelectItemTotalBoolean,
                SelectItemTotalDate,
                SelectItemTotalTime,
                SelectItemTotalDatetime,
                SelectItemTotalUuid
            >)
                value
        )
    { }

    public SelectItemTotalNonNullable(SelectItemTotalDatetime value)
        : this(
            (OneOf<
                SelectItemTotalInteger,
                SelectItemTotalDecimal,
                SelectItemTotalString,
                SelectItemTotalBoolean,
                SelectItemTotalDate,
                SelectItemTotalTime,
                SelectItemTotalDatetime,
                SelectItemTotalUuid
            >)
                value
        )
    { }

    public SelectItemTotalNonNullable(SelectItemTotalUuid value)
        : this(
            (OneOf<
                SelectItemTotalInteger,
                SelectItemTotalDecimal,
                SelectItemTotalString,
                SelectItemTotalBoolean,
                SelectItemTotalDate,
                SelectItemTotalTime,
                SelectItemTotalDatetime,
                SelectItemTotalUuid
            >)
                value
        )
    { }

    private SelectItemTotalNonNullable(
        OneOf<
            SelectItemTotalInteger,
            SelectItemTotalDecimal,
            SelectItemTotalString,
            SelectItemTotalBoolean,
            SelectItemTotalDate,
            SelectItemTotalTime,
            SelectItemTotalDatetime,
            SelectItemTotalUuid
        > input
    )
        : base(input) { }
}
