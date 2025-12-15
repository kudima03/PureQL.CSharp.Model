using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Equalities;

public sealed record NumberEquality
{
    public NumberEquality(NumberReturning left, NumberReturning right)
    {
        Left = left;
        Right = right;
    }

    public NumberReturning Left { get; }

    public NumberReturning Right { get; }
}
