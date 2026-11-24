using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asBoolean.boolean@total</c>.</summary>
public sealed record AsBooleanBooleanTotal : IOperator
{
    public AsBooleanBooleanTotal(StringTotal operand)
    {
        Operand = operand;
    }

    public StringTotal Operand { get; }

    public IType Type => new TypeBoolean();
}
