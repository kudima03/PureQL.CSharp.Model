using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asDate.string.date.nullable@group</c>.</summary>
public sealed record AsDateStringDateNullableGroup : IOperator
{
    public AsDateStringDateNullableGroup(DeclaresStringNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableGroup Operand { get; }

    public IType Type => new TypeDateNullable();
}
