using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asString.uuid.string@total</c>.</summary>
public sealed record AsStringUuidStringTotal : IOperator
{
    public AsStringUuidStringTotal(UuidTotal operand)
    {
        Operand = operand;
    }

    public UuidTotal Operand { get; }

    public IType Type => new TypeString();
}
