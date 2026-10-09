using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

public sealed record LiteralDatetimeNullable : ILiteral
{
    public IType Type => new TypeDatetimeNullable();
}
