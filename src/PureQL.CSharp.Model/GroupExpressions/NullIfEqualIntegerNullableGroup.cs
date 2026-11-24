using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>nullIfEqual.integer.nullable@group</c>.</summary>
public sealed record NullIfEqualIntegerNullableGroup : IOperator
{
    public NullIfEqualIntegerNullableGroup(
        IntegerNullableGroup left,
        DecimalNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public IntegerNullableGroup Left { get; }

    public DecimalNullableGroup Right { get; }

    public IType Type => new TypeIntegerNullable();
}
