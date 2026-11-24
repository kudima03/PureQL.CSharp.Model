using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>timeFromParts.time.nullable@row</c>.</summary>
public sealed record TimeFromPartsTimeNullableRow : IOperator
{
    public TimeFromPartsTimeNullableRow(
        IntegerNullableRow hour,
        IntegerNullableRow minute,
        DecimalNullableRow second
    )
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    public IntegerNullableRow Hour { get; }

    public IntegerNullableRow Minute { get; }

    public DecimalNullableRow Second { get; }

    public IType Type => new TypeTimeNullable();
}
