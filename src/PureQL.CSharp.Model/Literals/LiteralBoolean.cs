using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

public sealed record LiteralBoolean : ILiteral
{
    public LiteralBoolean(bool value)
    {
        Value = value;
    }

    public bool Value { get; }

    public IType Type => new TypeBoolean();
}
