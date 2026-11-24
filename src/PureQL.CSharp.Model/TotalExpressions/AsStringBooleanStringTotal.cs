using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asString.boolean.string@total</c>.</summary>
public sealed record AsStringBooleanStringTotal : IOperator
{
    public AsStringBooleanStringTotal(BooleanTotal operand)
    {
        Operand = operand;
    }

    public BooleanTotal Operand { get; }

    public IType Type => new TypeString();
}
