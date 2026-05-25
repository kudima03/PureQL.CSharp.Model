using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachDateArithmetics;

public sealed record EachDateAddDays
{
    public EachDateAddDays(
        OneOf<DateReturning, DateArrayReturning> left,
        OneOf<NumberReturning, NumberArrayReturning> right
    )
    {
        Left = left;
        Right = right;
    }

    public OneOf<DateReturning, DateArrayReturning> Left { get; }

    public OneOf<NumberReturning, NumberArrayReturning> Right { get; }
}
