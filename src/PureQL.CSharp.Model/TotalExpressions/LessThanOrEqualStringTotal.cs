using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>lessThanOrEqual.string@total</c>.</summary>
public sealed record LessThanOrEqualStringTotal : IOperator
{
    public LessThanOrEqualStringTotal(StringNullableTotal left, StringNullableTotal right)
    {
        Left = left;
        Right = right;
    }

    public StringNullableTotal Left { get; }

    public StringNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
