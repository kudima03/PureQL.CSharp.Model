using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>timeFromParts.time.nullable@group</c>.</summary>
public sealed record TimeFromPartsTimeNullableGroup : IOperator
{
    public TimeFromPartsTimeNullableGroup(
        IntegerNullableGroup hour,
        IntegerNullableGroup minute,
        DecimalNullableGroup second
    )
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    public IntegerNullableGroup Hour { get; }

    public IntegerNullableGroup Minute { get; }

    public DecimalNullableGroup Second { get; }

    public IType Type => new TypeTimeNullable();
}
