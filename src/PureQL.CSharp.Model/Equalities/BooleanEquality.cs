using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Equalities;

public sealed record BooleanEquality
{
    public BooleanEquality(BooleanReturning left, BooleanReturning right)
    {
        Left = left;
        Right = right;
    }

    public BooleanReturning Left { get; }

    public BooleanReturning Right { get; }
}
