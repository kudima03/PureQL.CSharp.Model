using OneOf;

namespace PureQL.CSharp.Model;

public sealed class Query : OneOfBase<GroupedQuery, PlainQuery, TotalQuery>
{
    public Query(GroupedQuery value)
        : this((OneOf<GroupedQuery, PlainQuery, TotalQuery>)value) { }

    public Query(PlainQuery value)
        : this((OneOf<GroupedQuery, PlainQuery, TotalQuery>)value) { }

    public Query(TotalQuery value)
        : this((OneOf<GroupedQuery, PlainQuery, TotalQuery>)value) { }

    private Query(OneOf<GroupedQuery, PlainQuery, TotalQuery> input)
        : base(input) { }
}
