using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record LessThanDecimalGroup : IOperator
{
    public LessThanDecimalGroup(DecimalNullableGroup left, DecimalNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableGroup Left { get; }

    public DecimalNullableGroup Right { get; }

    public IType Type => new TypeBoolean();
}
