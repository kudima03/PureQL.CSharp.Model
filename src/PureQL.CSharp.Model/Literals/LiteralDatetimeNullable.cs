using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

/// <summary>PureQL <c>literal.datetime.nullable</c>.</summary>
public sealed record LiteralDatetimeNullable : ILiteral
{
    public IType Type => new TypeDatetimeNullable();
}
