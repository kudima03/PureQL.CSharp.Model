using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asUuid.uuid@total</c>.</summary>
public sealed record AsUuidUuidTotal : IOperator
{
    public AsUuidUuidTotal(StringTotal operand)
    {
        Operand = operand;
    }

    public StringTotal Operand { get; }

    public IType Type => new TypeUuid();
}
