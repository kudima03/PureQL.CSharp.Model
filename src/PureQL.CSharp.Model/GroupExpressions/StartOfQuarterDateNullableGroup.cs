using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfQuarter.date.nullable@group</c>.</summary>
public sealed record StartOfQuarterDateNullableGroup : IOperator
{
    public StartOfQuarterDateNullableGroup(DeclaresDateNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableGroup Operand { get; }

    public IType Type => new TypeDateNullable();
}
