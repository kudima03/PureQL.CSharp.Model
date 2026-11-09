using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>greaterThanOrEqual.string@total</c>.</summary>
public sealed record GreaterThanOrEqualStringTotal : IOperator
{
    public GreaterThanOrEqualStringTotal(
        StringNullableTotal left,
        StringNullableTotal right
    )
    {
        Left = left;
        Right = right;
    }

    public StringNullableTotal Left { get; }

    public StringNullableTotal Right { get; }

    public IType Type => new TypeBoolean();
}
