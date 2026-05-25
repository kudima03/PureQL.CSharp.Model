using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachTimeArithmetics;

public sealed record EachTimeAddSeconds
{
    public EachTimeAddSeconds(
        OneOf<TimeReturning, TimeArrayReturning> left,
        OneOf<NumberReturning, NumberArrayReturning> right
    )
    {
        Left = left;
        Right = right;
    }

    public OneOf<TimeReturning, TimeArrayReturning> Left { get; }

    public OneOf<NumberReturning, NumberArrayReturning> Right { get; }
}
