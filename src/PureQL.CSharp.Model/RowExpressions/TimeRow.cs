using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class TimeRow
    : OneOfBase<
        FieldTime,
        ParamTime,
        LiteralTime,
        TimeAddSecondsTimeRow,
        ConditionalTimeRow
    >
{
    public TimeRow(FieldTime value)
        : this(
            (OneOf<
                FieldTime,
                ParamTime,
                LiteralTime,
                TimeAddSecondsTimeRow,
                ConditionalTimeRow
            >)
                value
        )
    { }

    public TimeRow(ParamTime value)
        : this(
            (OneOf<
                FieldTime,
                ParamTime,
                LiteralTime,
                TimeAddSecondsTimeRow,
                ConditionalTimeRow
            >)
                value
        )
    { }

    public TimeRow(LiteralTime value)
        : this(
            (OneOf<
                FieldTime,
                ParamTime,
                LiteralTime,
                TimeAddSecondsTimeRow,
                ConditionalTimeRow
            >)
                value
        )
    { }

    public TimeRow(TimeAddSecondsTimeRow value)
        : this(
            (OneOf<
                FieldTime,
                ParamTime,
                LiteralTime,
                TimeAddSecondsTimeRow,
                ConditionalTimeRow
            >)
                value
        )
    { }

    public TimeRow(ConditionalTimeRow value)
        : this(
            (OneOf<
                FieldTime,
                ParamTime,
                LiteralTime,
                TimeAddSecondsTimeRow,
                ConditionalTimeRow
            >)
                value
        )
    { }

    private TimeRow(
        OneOf<
            FieldTime,
            ParamTime,
            LiteralTime,
            TimeAddSecondsTimeRow,
            ConditionalTimeRow
        > input
    )
        : base(input) { }
}
