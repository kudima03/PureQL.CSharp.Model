using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

/// <summary>PureQL <c>literal.uuid</c>.</summary>
public sealed record LiteralUuid : ILiteral
{
    public LiteralUuid(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; }

    public IType Type => new TypeUuid();
}
