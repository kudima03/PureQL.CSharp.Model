using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>normalize.string@projection</c>.</summary>
public sealed record NormalizeStringProjection : IOperator
{
    public NormalizeStringProjection(StringProjection operand, NormalizationForm form)
    {
        Operand = operand;
        Form = form;
    }

    public StringProjection Operand { get; }

    public NormalizationForm Form { get; }

    public IType Type => new TypeString();
}
