using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>concatWith@total</c>.</summary>
public sealed record ConcatWithTotal : IOperator
{
    public ConcatWithTotal(IEnumerable<StringNullableTotal> values, StringTotal separator)
    {
        Values = values;
        Separator = separator;
    }

    public IEnumerable<StringNullableTotal> Values { get; }

    public StringTotal Separator { get; }

    public IType Type => new TypeString();
}
