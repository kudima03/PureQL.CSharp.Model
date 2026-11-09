using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>timeAddSeconds.time.nullable@group</c>.</summary>
public sealed record TimeAddSecondsTimeNullableGroup : IOperator
{
    public TimeAddSecondsTimeNullableGroup(
        TimeNullableGroup left,
        DecimalNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public TimeNullableGroup Left { get; }

    public DecimalNullableGroup Right { get; }

    public IType Type => new TypeTimeNullable();
}
