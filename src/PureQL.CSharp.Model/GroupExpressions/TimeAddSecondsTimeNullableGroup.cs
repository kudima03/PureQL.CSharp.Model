using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>timeAddSeconds.time.nullable@group</c>.</summary>
public sealed record TimeAddSecondsTimeNullableGroup : IOperator
{
    public TimeAddSecondsTimeNullableGroup(
        TimeNullableGroup operand,
        DecimalNullableGroup seconds
    )
    {
        Operand = operand;
        Seconds = seconds;
    }

    public TimeNullableGroup Operand { get; }

    public DecimalNullableGroup Seconds { get; }

    public IType Type => new TypeTimeNullable();
}
