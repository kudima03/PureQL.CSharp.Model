using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.ArrayEqualities;

public sealed record UuidArrayEquality
{
    public UuidArrayEquality(UuidArrayReturning left, UuidArrayReturning right)
    {
        Left = left;
        Right = right;
    }

    public UuidArrayReturning Left { get; }

    public UuidArrayReturning Right { get; }
}
