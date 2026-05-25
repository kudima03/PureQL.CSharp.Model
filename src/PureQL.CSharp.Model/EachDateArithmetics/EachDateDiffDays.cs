using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachDateArithmetics;

public sealed record EachDateDiffDays
{
    public EachDateDiffDays(
        OneOf<DateReturning, DateArrayReturning> left,
        OneOf<DateReturning, DateArrayReturning> right
    )
    {
        Left = left;
        Right = right;
    }

    public OneOf<DateReturning, DateArrayReturning> Left { get; }

    public OneOf<DateReturning, DateArrayReturning> Right { get; }
}
