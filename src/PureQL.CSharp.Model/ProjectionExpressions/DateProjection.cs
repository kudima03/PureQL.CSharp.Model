using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class DateProjection
    : OneOfBase<
        FieldDate,
        ParamDate,
        LiteralDate,
        DateAddDaysDateProjection,
        ConditionalDateProjection
    >
{
    public DateProjection(FieldDate value)
        : this(
            (OneOf<
                FieldDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateProjection,
                ConditionalDateProjection
            >)
                value
        )
    { }

    public DateProjection(ParamDate value)
        : this(
            (OneOf<
                FieldDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateProjection,
                ConditionalDateProjection
            >)
                value
        )
    { }

    public DateProjection(LiteralDate value)
        : this(
            (OneOf<
                FieldDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateProjection,
                ConditionalDateProjection
            >)
                value
        )
    { }

    public DateProjection(DateAddDaysDateProjection value)
        : this(
            (OneOf<
                FieldDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateProjection,
                ConditionalDateProjection
            >)
                value
        )
    { }

    public DateProjection(ConditionalDateProjection value)
        : this(
            (OneOf<
                FieldDate,
                ParamDate,
                LiteralDate,
                DateAddDaysDateProjection,
                ConditionalDateProjection
            >)
                value
        )
    { }

    private DateProjection(
        OneOf<
            FieldDate,
            ParamDate,
            LiteralDate,
            DateAddDaysDateProjection,
            ConditionalDateProjection
        > input
    )
        : base(input) { }
}
