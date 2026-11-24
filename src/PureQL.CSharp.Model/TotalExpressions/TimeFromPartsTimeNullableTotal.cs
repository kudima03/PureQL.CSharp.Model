using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>timeFromParts.time.nullable@total</c>.</summary>
public sealed record TimeFromPartsTimeNullableTotal : IOperator
{
    public TimeFromPartsTimeNullableTotal(
        IntegerNullableTotal hour,
        IntegerNullableTotal minute,
        DecimalNullableTotal second
    )
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    public IntegerNullableTotal Hour { get; }

    public IntegerNullableTotal Minute { get; }

    public DecimalNullableTotal Second { get; }

    public IType Type => new TypeTimeNullable();
}
