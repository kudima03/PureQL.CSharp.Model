using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>datetimeAddSeconds.datetime.nullable@group</c>.</summary>
public sealed record DatetimeAddSecondsDatetimeNullableGroup : IOperator
{
    public DatetimeAddSecondsDatetimeNullableGroup(
        DatetimeNullableGroup left,
        DecimalNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableGroup Left { get; }

    public DecimalNullableGroup Right { get; }

    public IType Type => new TypeDatetimeNullable();
}
