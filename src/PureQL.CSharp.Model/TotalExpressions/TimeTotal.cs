using OneOf;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class TimeTotal
    : OneOfBase<ParamTime, LiteralTime, TimeAddSecondsTimeTotal, ConditionalTimeTotal>
{
    public TimeTotal(ParamTime value)
        : this(
            (OneOf<ParamTime, LiteralTime, TimeAddSecondsTimeTotal, ConditionalTimeTotal>)
                value
        )
    { }

    public TimeTotal(LiteralTime value)
        : this(
            (OneOf<ParamTime, LiteralTime, TimeAddSecondsTimeTotal, ConditionalTimeTotal>)
                value
        )
    { }

    public TimeTotal(TimeAddSecondsTimeTotal value)
        : this(
            (OneOf<ParamTime, LiteralTime, TimeAddSecondsTimeTotal, ConditionalTimeTotal>)
                value
        )
    { }

    public TimeTotal(ConditionalTimeTotal value)
        : this(
            (OneOf<ParamTime, LiteralTime, TimeAddSecondsTimeTotal, ConditionalTimeTotal>)
                value
        )
    { }

    private TimeTotal(
        OneOf<ParamTime, LiteralTime, TimeAddSecondsTimeTotal, ConditionalTimeTotal> input
    )
        : base(input) { }
}
