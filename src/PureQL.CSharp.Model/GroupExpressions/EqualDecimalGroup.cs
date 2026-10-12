using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record EqualDecimalGroup : IOperator
{
    public EqualDecimalGroup(DecimalNullableGroup left, DecimalNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableGroup Left { get; }

    public DecimalNullableGroup Right { get; }

    public IType Type => new TypeBoolean();
}
