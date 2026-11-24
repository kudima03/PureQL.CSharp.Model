using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>timeFromParts.time@row</c>.</summary>
public sealed record TimeFromPartsTimeRow : IOperator
{
    public TimeFromPartsTimeRow(IntegerRow hour, IntegerRow minute, DecimalRow second)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    public IntegerRow Hour { get; }

    public IntegerRow Minute { get; }

    public DecimalRow Second { get; }

    public IType Type => new TypeTime();
}
