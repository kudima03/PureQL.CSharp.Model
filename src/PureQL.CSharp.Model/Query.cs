using OneOf;

namespace PureQL.CSharp.Model;

public sealed class Query : OneOfBase<GroupedQuery, PlainQuery>
{
    public Query(GroupedQuery value)
        : this((OneOf<GroupedQuery, PlainQuery>)value) { }

    public Query(PlainQuery value)
        : this((OneOf<GroupedQuery, PlainQuery>)value) { }

    private Query(OneOf<GroupedQuery, PlainQuery> input)
        : base(input) { }
}
