using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.ArrayEqualities;

public sealed record DateTimeArrayEquality
{
    public DateTimeArrayEquality(
        DateTimeArrayReturning left,
        DateTimeArrayReturning right
    )
    {
        Left = left;
        Right = right;
    }

    public DateTimeArrayReturning Left { get; }

    public DateTimeArrayReturning Right { get; }
}
