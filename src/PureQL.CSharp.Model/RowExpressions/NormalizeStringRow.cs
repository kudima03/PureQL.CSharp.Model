using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>normalize.string@row</c>.</summary>
public sealed record NormalizeStringRow : IOperator
{
    public NormalizeStringRow(StringRow operand, NormalizationForm form)
    {
        Operand = operand;
        Form = form;
    }

    public StringRow Operand { get; }

    public NormalizationForm Form { get; }

    public IType Type => new TypeString();
}
