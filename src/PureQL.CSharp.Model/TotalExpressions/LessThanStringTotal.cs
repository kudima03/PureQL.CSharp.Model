using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record LessThanStringTotal : IOperator
{
    public LessThanStringTotal(StringNullableTotal left, StringNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public StringNullableTotal Left { get; }

    public StringNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
