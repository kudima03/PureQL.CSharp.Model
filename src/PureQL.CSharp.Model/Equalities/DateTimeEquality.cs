using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Equalities;

public sealed record DateTimeEquality
{
    public DateTimeEquality(DateTimeReturning left, DateTimeReturning right)
    {
        Left = left;
        Right = right;
    }

    public DateTimeReturning Left { get; }

    public DateTimeReturning Right { get; }
}
