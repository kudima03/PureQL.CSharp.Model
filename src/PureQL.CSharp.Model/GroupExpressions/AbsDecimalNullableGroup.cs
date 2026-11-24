using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>abs.decimal.nullable@group</c>.</summary>
public sealed record AbsDecimalNullableGroup : IOperator
{
    public AbsDecimalNullableGroup(DeclaresDecimalNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalNullableGroup Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
