using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ExactTimeNullableRow
    : OneOfBase<
        FieldTimeNullable,
        ParamTimeNullable,
        LiteralTimeNullable,
        TimeAddSecondsTimeNullableRow,
        ConditionalTimeNullableRow
    >
{
    public ExactTimeNullableRow(FieldTimeNullable value)
        : this(
            (OneOf<
                FieldTimeNullable,
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableRow,
                ConditionalTimeNullableRow
            >)
                value
        )
    { }

    public ExactTimeNullableRow(ParamTimeNullable value)
        : this(
            (OneOf<
                FieldTimeNullable,
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableRow,
                ConditionalTimeNullableRow
            >)
                value
        )
    { }

    public ExactTimeNullableRow(LiteralTimeNullable value)
        : this(
            (OneOf<
                FieldTimeNullable,
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableRow,
                ConditionalTimeNullableRow
            >)
                value
        )
    { }

    public ExactTimeNullableRow(TimeAddSecondsTimeNullableRow value)
        : this(
            (OneOf<
                FieldTimeNullable,
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableRow,
                ConditionalTimeNullableRow
            >)
                value
        )
    { }

    public ExactTimeNullableRow(ConditionalTimeNullableRow value)
        : this(
            (OneOf<
                FieldTimeNullable,
                ParamTimeNullable,
                LiteralTimeNullable,
                TimeAddSecondsTimeNullableRow,
                ConditionalTimeNullableRow
            >)
                value
        )
    { }

    private ExactTimeNullableRow(
        OneOf<
            FieldTimeNullable,
            ParamTimeNullable,
            LiteralTimeNullable,
            TimeAddSecondsTimeNullableRow,
            ConditionalTimeNullableRow
        > input
    )
        : base(input) { }
}
