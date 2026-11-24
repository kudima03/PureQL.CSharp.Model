using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asDate.string.date@total</c>.</summary>
public sealed record AsDateStringDateTotal : IOperator
{
    public AsDateStringDateTotal(StringTotal operand)
    {
        Operand = operand;
    }

    public StringTotal Operand { get; }

    public IType Type => new TypeDate();
}
