using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record GreaterThanUuidGroup : IOperator
{
    public GreaterThanUuidGroup(UuidNullableGroup left, UuidNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public UuidNullableGroup Left { get; }

    public UuidNullableGroup Right { get; }

    public IType Type => new TypeBoolean();
}
