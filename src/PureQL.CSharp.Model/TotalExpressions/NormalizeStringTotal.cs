using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>normalize.string@total</c>.</summary>
public sealed record NormalizeStringTotal : IOperator
{
    public NormalizeStringTotal(StringTotal operand, NormalizationForm form)
    {
        Operand = operand;
        Form = form;
    }

    public StringTotal Operand { get; }

    public NormalizationForm Form { get; }

    public IType Type => new TypeString();
}
