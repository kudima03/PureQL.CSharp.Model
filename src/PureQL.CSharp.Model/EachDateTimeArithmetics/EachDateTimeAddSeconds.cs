using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachDateTimeArithmetics;

public sealed record EachDateTimeAddSeconds
{
    public EachDateTimeAddSeconds(
        OneOf<DateTimeReturning, DateTimeArrayReturning> left,
        OneOf<NumberReturning, NumberArrayReturning> right
    )
    {
        Left = left;
        Right = right;
    }

    public OneOf<DateTimeReturning, DateTimeArrayReturning> Left { get; }

    public OneOf<NumberReturning, NumberArrayReturning> Right { get; }
}
