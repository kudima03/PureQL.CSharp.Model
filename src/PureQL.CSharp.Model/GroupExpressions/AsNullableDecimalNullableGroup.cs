using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asNullable.decimal.nullable@group</c>.</summary>
public sealed record AsNullableDecimalNullableGroup : IOperator
{
    public AsNullableDecimalNullableGroup(DeclaresDecimalGroup operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalGroup Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
