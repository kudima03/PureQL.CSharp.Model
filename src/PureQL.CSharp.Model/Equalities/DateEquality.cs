using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Equalities;

public sealed record DateEquality
{
    public DateEquality(DateReturning left, DateReturning right)
    {
        Left = left;
        Right = right;
    }

    public DateReturning Left { get; }

    public DateReturning Right { get; }
}
