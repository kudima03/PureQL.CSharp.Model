using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

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
