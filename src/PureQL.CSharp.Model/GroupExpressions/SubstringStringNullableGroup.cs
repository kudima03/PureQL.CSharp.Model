using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>substring.string.nullable@group</c>.</summary>
public sealed record SubstringStringNullableGroup : IOperator
{
    public SubstringStringNullableGroup(
        StringNullableGroup operand,
        IntegerNullableGroup start,
        IntegerNullableGroup? length = null
    )
    {
        Operand = operand;
        Start = start;
        Length = length;
    }

    public StringNullableGroup Operand { get; }

    public IntegerNullableGroup Start { get; }

    public IntegerNullableGroup? Length { get; }

    public IType Type => new TypeStringNullable();
}
