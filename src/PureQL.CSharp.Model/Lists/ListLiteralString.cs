using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Lists;

public sealed record ListLiteralString : ILiteral
{
    public ListLiteralString(IEnumerable<string> value)
    {
        Value = value;
    }

    public IEnumerable<string> Value { get; }

    public IType Type => new TypeStringList();
}
