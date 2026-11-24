using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>nullIfEqual.datetime.nullable@group</c>.</summary>
public sealed record NullIfEqualDatetimeNullableGroup : IOperator
{
    public NullIfEqualDatetimeNullableGroup(
        DatetimeNullableGroup left,
        DatetimeNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableGroup Left { get; }

    public DatetimeNullableGroup Right { get; }

    public IType Type => new TypeDatetimeNullable();
}
