using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.ArrayEqualities;

public sealed record TimeArrayEquality
{
    public TimeArrayEquality(TimeArrayReturning left, TimeArrayReturning right)
    {
        Left = left;
        Right = right;
    }

    public TimeArrayReturning Left { get; }

    public TimeArrayReturning Right { get; }
}
