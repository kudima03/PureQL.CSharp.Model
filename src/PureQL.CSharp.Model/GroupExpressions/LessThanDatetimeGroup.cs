using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record LessThanDatetimeGroup : IOperator
{
    public LessThanDatetimeGroup(DatetimeNullableGroup left, DatetimeNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableGroup Left { get; }

    public DatetimeNullableGroup Right { get; }

    public IType Type => new TypeBoolean();
}
