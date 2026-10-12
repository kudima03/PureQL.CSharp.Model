using OneOf;

namespace PureQL.CSharp.Model;

public sealed class PureQLQuery
    : OneOfBase<MainGroupedQuery, MainPlainQuery, MainTotalQuery>
{
    public PureQLQuery(MainGroupedQuery value)
        : this((OneOf<MainGroupedQuery, MainPlainQuery, MainTotalQuery>)value) { }

    public PureQLQuery(MainPlainQuery value)
        : this((OneOf<MainGroupedQuery, MainPlainQuery, MainTotalQuery>)value) { }

    public PureQLQuery(MainTotalQuery value)
        : this((OneOf<MainGroupedQuery, MainPlainQuery, MainTotalQuery>)value) { }

    private PureQLQuery(OneOf<MainGroupedQuery, MainPlainQuery, MainTotalQuery> input)
        : base(input) { }
}
