using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>timeFromParts.time@total</c>.</summary>
public sealed record TimeFromPartsTimeTotal : IOperator
{
    public TimeFromPartsTimeTotal(
        IntegerTotal hour,
        IntegerTotal minute,
        DecimalTotal second
    )
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    public IntegerTotal Hour { get; }

    public IntegerTotal Minute { get; }

    public DecimalTotal Second { get; }

    public IType Type => new TypeTime();
}
