using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record LessThanOrEqualBooleanGroup : IOperator
{
    public LessThanOrEqualBooleanGroup(
        BooleanNullableGroup left,
        BooleanNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public BooleanNullableGroup Left { get; }

    public BooleanNullableGroup Right { get; }

    public IType Type => new TypeBoolean();
}
