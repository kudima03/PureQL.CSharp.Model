using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record RoundIntegerNullableGroup : IOperator
{
    public RoundIntegerNullableGroup(DecimalNullableGroup operand)
    {
        Operand = operand;
    }

    public DecimalNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
