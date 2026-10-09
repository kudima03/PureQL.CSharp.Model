using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class TimeNullableRow
    : OneOfBase<
        FieldAsTimeNullable,
        ParamAsTimeNullable,
        LiteralAsTimeNullable,
        TimeAddSecondsTimeNullableRow,
        ConditionalTimeNullableRow
    >
{
    public TimeNullableRow(FieldAsTimeNullable value)
        : this(
            (OneOf<
                FieldAsTimeNullable,
                ParamAsTimeNullable,
                LiteralAsTimeNullable,
                TimeAddSecondsTimeNullableRow,
                ConditionalTimeNullableRow
            >)
                value
        )
    { }

    public TimeNullableRow(ParamAsTimeNullable value)
        : this(
            (OneOf<
                FieldAsTimeNullable,
                ParamAsTimeNullable,
                LiteralAsTimeNullable,
                TimeAddSecondsTimeNullableRow,
                ConditionalTimeNullableRow
            >)
                value
        )
    { }

    public TimeNullableRow(LiteralAsTimeNullable value)
        : this(
            (OneOf<
                FieldAsTimeNullable,
                ParamAsTimeNullable,
                LiteralAsTimeNullable,
                TimeAddSecondsTimeNullableRow,
                ConditionalTimeNullableRow
            >)
                value
        )
    { }

    public TimeNullableRow(TimeAddSecondsTimeNullableRow value)
        : this(
            (OneOf<
                FieldAsTimeNullable,
                ParamAsTimeNullable,
                LiteralAsTimeNullable,
                TimeAddSecondsTimeNullableRow,
                ConditionalTimeNullableRow
            >)
                value
        )
    { }

    public TimeNullableRow(ConditionalTimeNullableRow value)
        : this(
            (OneOf<
                FieldAsTimeNullable,
                ParamAsTimeNullable,
                LiteralAsTimeNullable,
                TimeAddSecondsTimeNullableRow,
                ConditionalTimeNullableRow
            >)
                value
        )
    { }

    private TimeNullableRow(
        OneOf<
            FieldAsTimeNullable,
            ParamAsTimeNullable,
            LiteralAsTimeNullable,
            TimeAddSecondsTimeNullableRow,
            ConditionalTimeNullableRow
        > input
    )
        : base(input) { }
}
