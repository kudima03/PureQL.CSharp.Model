using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.ArrayEqualities;

public sealed record StringArrayEquality
{
    public StringArrayEquality(StringArrayReturning left, StringArrayReturning right)
    {
        Left = left;
        Right = right;
    }

    public StringArrayReturning Left { get; }

    public StringArrayReturning Right { get; }
}
