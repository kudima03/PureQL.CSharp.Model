using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.ArrayEqualities;

public sealed record NumberArrayEquality
{
    public NumberArrayEquality(NumberArrayReturning left, NumberArrayReturning right)
    {
        Left = left;
        Right = right;
    }

    public NumberArrayReturning Left { get; }

    public NumberArrayReturning Right { get; }
}
