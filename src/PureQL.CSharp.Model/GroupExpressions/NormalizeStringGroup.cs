using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>normalize.string@group</c>.</summary>
public sealed record NormalizeStringGroup : IOperator
{
    public NormalizeStringGroup(StringGroup operand, NormalizationForm form)
    {
        Operand = operand;
        Form = form;
    }

    public StringGroup Operand { get; }

    public NormalizationForm Form { get; }

    public IType Type => new TypeString();
}
