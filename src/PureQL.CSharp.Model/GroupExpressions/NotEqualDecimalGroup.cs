using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>notEqual.decimal@group</c>.</summary>
public sealed record NotEqualDecimalGroup : IOperator
{
    public NotEqualDecimalGroup(DecimalNullableGroup left, DecimalNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableGroup Left { get; }

    public DecimalNullableGroup Right { get; }

    public IType Type => new TypeBoolean();
}
