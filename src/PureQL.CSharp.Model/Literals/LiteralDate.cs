using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

/// <summary>PureQL <c>literal.date</c>.</summary>
public sealed record LiteralDate : ILiteral
{
    public LiteralDate(DateOnly value)
    {
        Value = value;
    }

    public DateOnly Value { get; }

    public IType Type => new TypeDate();
}
