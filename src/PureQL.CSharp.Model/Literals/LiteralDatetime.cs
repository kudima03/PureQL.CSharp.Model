using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

/// <summary>PureQL <c>literal.datetime</c>.</summary>
public sealed record LiteralDatetime : ILiteral
{
    public LiteralDatetime(DateTimeOffset value)
    {
        Value = value;
    }

    public DateTimeOffset Value { get; }

    public IType Type => new TypeDatetime();
}
