using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record GreaterThanDatetimeGroup : IOperator
{
    public GreaterThanDatetimeGroup(
        DatetimeNullableGroup left,
        DatetimeNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableGroup Left { get; }

    public DatetimeNullableGroup Right { get; }

    public IType Type => new TypeBoolean();
}
