using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>lessThanOrEqual.decimal@group</c>.</summary>
public sealed record LessThanOrEqualDecimalGroup : IOperator
{
    public LessThanOrEqualDecimalGroup(
        DecimalNullableGroup left,
        DecimalNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableGroup Left { get; }

    public DecimalNullableGroup Right { get; }

    public IType Type => new TypeBoolean();
}
