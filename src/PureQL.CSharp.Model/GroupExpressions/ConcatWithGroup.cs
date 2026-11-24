using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>concatWith@group</c>.</summary>
public sealed record ConcatWithGroup : IOperator
{
    public ConcatWithGroup(IEnumerable<StringNullableGroup> values, StringGroup separator)
    {
        Values = values;
        Separator = separator;
    }

    public IEnumerable<StringNullableGroup> Values { get; }

    public StringGroup Separator { get; }

    public IType Type => new TypeString();
}
