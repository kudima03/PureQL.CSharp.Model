using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asTime.string.time@total</c>.</summary>
public sealed record AsTimeStringTimeTotal : IOperator
{
    public AsTimeStringTimeTotal(StringTotal operand)
    {
        Operand = operand;
    }

    public StringTotal Operand { get; }

    public IType Type => new TypeTime();
}
