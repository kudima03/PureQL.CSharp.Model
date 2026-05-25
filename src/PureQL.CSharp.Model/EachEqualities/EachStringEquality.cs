using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachEqualities;

public sealed record EachStringEquality
{
    public EachStringEquality(
        StringArrayReturning left,
        OneOf<StringReturning, StringArrayReturning> right
    )
    {
        Left = left;
        Right = right;
    }

    public StringArrayReturning Left { get; }

    public OneOf<StringReturning, StringArrayReturning> Right { get; }
}
