using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record ConcatStringTotal : IOperator
{
    public ConcatStringTotal(IEnumerable<StringTotal> values)
    {
        Values = values;
    }

    public IEnumerable<StringTotal> Values { get; }

    public IType Type => new TypeString();
}
