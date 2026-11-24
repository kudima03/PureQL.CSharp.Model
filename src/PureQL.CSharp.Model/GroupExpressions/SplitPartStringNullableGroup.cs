using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>splitPart.string.nullable@group</c>.</summary>
public sealed record SplitPartStringNullableGroup : IOperator
{
    public SplitPartStringNullableGroup(
        StringNullableGroup operand,
        StringNullableGroup delimiter,
        IntegerNullableGroup index
    )
    {
        Operand = operand;
        Delimiter = delimiter;
        Index = index;
    }

    public StringNullableGroup Operand { get; }

    public StringNullableGroup Delimiter { get; }

    public IntegerNullableGroup Index { get; }

    public IType Type => new TypeStringNullable();
}
