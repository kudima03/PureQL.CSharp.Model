using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Equalities;

public sealed record UuidEquality
{
    public UuidEquality(UuidReturning left, UuidReturning right)
    {
        Left = left;
        Right = right;
    }

    public UuidReturning Left { get; }

    public UuidReturning Right { get; }
}
