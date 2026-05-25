using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachEqualities;

public sealed record EachUuidEquality
{
    public EachUuidEquality(
        UuidArrayReturning left,
        OneOf<UuidReturning, UuidArrayReturning> right
    )
    {
        Left = left;
        Right = right;
    }

    public UuidArrayReturning Left { get; }

    public OneOf<UuidReturning, UuidArrayReturning> Right { get; }
}
