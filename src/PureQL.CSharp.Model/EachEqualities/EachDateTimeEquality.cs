using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachEqualities;

public sealed record EachDateTimeEquality
{
    public EachDateTimeEquality(
        DateTimeArrayReturning left,
        OneOf<DateTimeReturning, DateTimeArrayReturning> right
    )
    {
        Left = left;
        Right = right;
    }

    public DateTimeArrayReturning Left { get; }

    public OneOf<DateTimeReturning, DateTimeArrayReturning> Right { get; }
}
