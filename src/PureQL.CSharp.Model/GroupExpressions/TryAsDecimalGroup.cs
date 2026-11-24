using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>tryAsDecimal@group</c>.</summary>
public sealed record TryAsDecimalGroup : IOperator
{
    public TryAsDecimalGroup(StringNullableGroup operand)
    {
        Operand = operand;
    }

    public StringNullableGroup Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
