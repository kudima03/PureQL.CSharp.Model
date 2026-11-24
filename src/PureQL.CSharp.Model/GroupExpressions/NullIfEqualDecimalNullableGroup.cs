using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>nullIfEqual.decimal.nullable@group</c>.</summary>
public sealed record NullIfEqualDecimalNullableGroup : IOperator
{
    public NullIfEqualDecimalNullableGroup(
        DecimalOrDecimalNullableGroup left,
        DecimalNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public DecimalOrDecimalNullableGroup Left { get; }

    public DecimalNullableGroup Right { get; }

    public IType Type => new TypeDecimalNullable();
}
