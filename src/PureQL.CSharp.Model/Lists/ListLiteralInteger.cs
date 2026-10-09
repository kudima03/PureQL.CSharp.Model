using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Lists;

public sealed record ListLiteralInteger : ILiteral
{
    public ListLiteralInteger(IEnumerable<long> value)
    {
        Value = value;
    }

    public IEnumerable<long> Value { get; }

    public IType Type => new TypeIntegerList();
}
