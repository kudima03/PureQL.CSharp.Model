using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>tryAsUuid@group</c>.</summary>
public sealed record TryAsUuidGroup : IOperator
{
    public TryAsUuidGroup(StringNullableGroup operand)
    {
        Operand = operand;
    }

    public StringNullableGroup Operand { get; }

    public IType Type => new TypeUuidNullable();
}
