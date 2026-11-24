using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>trimStart.string.nullable@group</c>.</summary>
public sealed record TrimStartStringNullableGroup : IOperator
{
    public TrimStartStringNullableGroup(
        DeclaresStringNullableGroup operand,
        IEnumerable<StringGroup> removables
    )
    {
        Operand = operand;
        Removables = removables;
    }

    public DeclaresStringNullableGroup Operand { get; }

    public IEnumerable<StringGroup> Removables { get; }

    public IType Type => new TypeStringNullable();
}
