using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asDatetime.string.datetime@total</c>.</summary>
public sealed record AsDatetimeStringDatetimeTotal : IOperator
{
    public AsDatetimeStringDatetimeTotal(StringTotal operand)
    {
        Operand = operand;
    }

    public StringTotal Operand { get; }

    public IType Type => new TypeDatetime();
}
