using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

public sealed record LiteralUuid : ILiteral
{
    public LiteralUuid(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; }

    public IType Type => new TypeUuid();
}
