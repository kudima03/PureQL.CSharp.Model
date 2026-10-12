using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record NotEqualBooleanGroup : IOperator
{
    public NotEqualBooleanGroup(BooleanNullableGroup left, BooleanNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public BooleanNullableGroup Left { get; }

    public BooleanNullableGroup Right { get; }

    public IType Type => new TypeBoolean();
}
