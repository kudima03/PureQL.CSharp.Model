using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>integerDivide.integer.nullable@group</c>.</summary>
public sealed record IntegerDivideIntegerNullableGroup : IOperator
{
    public IntegerDivideIntegerNullableGroup(
        DecimalNullableGroup left,
        DecimalNullableGroup right
    )
    {
        Left = left;
        Right = right;
    }

    public DecimalNullableGroup Left { get; }

    public DecimalNullableGroup Right { get; }

    public IType Type => new TypeIntegerNullable();
}
