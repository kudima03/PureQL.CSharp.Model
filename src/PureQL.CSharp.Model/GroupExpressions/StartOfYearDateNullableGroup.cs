using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfYear.date.nullable@group</c>.</summary>
public sealed record StartOfYearDateNullableGroup : IOperator
{
    public StartOfYearDateNullableGroup(DeclaresDateNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableGroup Operand { get; }

    public IType Type => new TypeDateNullable();
}
