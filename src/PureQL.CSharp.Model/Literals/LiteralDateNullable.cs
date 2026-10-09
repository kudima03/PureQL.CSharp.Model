using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

public sealed record LiteralDateNullable : ILiteral
{
    public IType Type => new TypeDateNullable();
}
