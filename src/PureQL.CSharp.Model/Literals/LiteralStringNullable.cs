using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

public sealed record LiteralStringNullable : ILiteral
{
    public IType Type => new TypeStringNullable();
}
