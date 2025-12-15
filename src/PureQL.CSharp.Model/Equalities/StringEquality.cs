using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Equalities;

public sealed record StringEquality
{
    public StringEquality(StringReturning left, StringReturning right)
    {
        Left = left;
        Right = right;
    }

    public StringReturning Left { get; }

    public StringReturning Right { get; }
}
