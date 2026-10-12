using OneOf;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class DateTotal
    : OneOfBase<ParamDate, LiteralDate, DateAddDaysDateTotal, ConditionalDateTotal>
{
    public DateTotal(ParamDate value)
        : this(
            (OneOf<ParamDate, LiteralDate, DateAddDaysDateTotal, ConditionalDateTotal>)
                value
        )
    { }

    public DateTotal(LiteralDate value)
        : this(
            (OneOf<ParamDate, LiteralDate, DateAddDaysDateTotal, ConditionalDateTotal>)
                value
        )
    { }

    public DateTotal(DateAddDaysDateTotal value)
        : this(
            (OneOf<ParamDate, LiteralDate, DateAddDaysDateTotal, ConditionalDateTotal>)
                value
        )
    { }

    public DateTotal(ConditionalDateTotal value)
        : this(
            (OneOf<ParamDate, LiteralDate, DateAddDaysDateTotal, ConditionalDateTotal>)
                value
        )
    { }

    private DateTotal(
        OneOf<ParamDate, LiteralDate, DateAddDaysDateTotal, ConditionalDateTotal> input
    )
        : base(input) { }
}
