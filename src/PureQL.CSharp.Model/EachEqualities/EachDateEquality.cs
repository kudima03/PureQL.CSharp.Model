using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachEqualities;

public sealed record EachDateEquality
{
    public EachDateEquality(
        DateArrayReturning left,
        OneOf<DateReturning, DateArrayReturning> right
    )
    {
        Left = left;
        Right = right;
    }

    public DateArrayReturning Left { get; }

    public OneOf<DateReturning, DateArrayReturning> Right { get; }
}
