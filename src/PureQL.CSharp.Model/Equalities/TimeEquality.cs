using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Equalities;

public sealed record TimeEquality
{
    public TimeEquality(TimeReturning left, TimeReturning right)
    {
        Left = left;
        Right = right;
    }

    public TimeReturning Left { get; }

    public TimeReturning Right { get; }
}
