using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.ArrayEqualities;

public sealed record DateArrayEquality
{
    public DateArrayEquality(DateArrayReturning left, DateArrayReturning right)
    {
        Left = left;
        Right = right;
    }

    public DateArrayReturning Left { get; }

    public DateArrayReturning Right { get; }
}
