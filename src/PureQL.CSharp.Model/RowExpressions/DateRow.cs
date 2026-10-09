using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class DateRow
    : OneOfBase<FieldDate, ParamDate, LiteralDate, DateAddDaysDateRow, ConditionalDateRow>
{
    public DateRow(FieldDate value)
        : this(
            (OneOf<
                FieldDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateRow,
                ConditionalDateRow
            >)
                value
        )
    { }

    public DateRow(ParamDate value)
        : this(
            (OneOf<
                FieldDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateRow,
                ConditionalDateRow
            >)
                value
        )
    { }

    public DateRow(LiteralDate value)
        : this(
            (OneOf<
                FieldDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateRow,
                ConditionalDateRow
            >)
                value
        )
    { }

    public DateRow(DateAddDaysDateRow value)
        : this(
            (OneOf<
                FieldDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateRow,
                ConditionalDateRow
            >)
                value
        )
    { }

    public DateRow(ConditionalDateRow value)
        : this(
            (OneOf<
                FieldDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateRow,
                ConditionalDateRow
            >)
                value
        )
    { }

    private DateRow(
        OneOf<
            FieldDate,
            ParamDate,
            LiteralDate,
            DateAddDaysDateRow,
            ConditionalDateRow
        > input
    )
        : base(input) { }
}
