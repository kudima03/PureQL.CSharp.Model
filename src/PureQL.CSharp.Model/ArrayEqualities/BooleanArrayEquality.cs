using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.ArrayEqualities;

public sealed record BooleanArrayEquality
{
    public BooleanArrayEquality(BooleanArrayReturning left, BooleanArrayReturning right)
    {
        Left = left;
        Right = right;
    }

    public BooleanArrayReturning Left { get; }

    public BooleanArrayReturning Right { get; }
}
