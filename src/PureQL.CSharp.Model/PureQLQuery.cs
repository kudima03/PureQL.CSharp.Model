using OneOf;

namespace PureQL.CSharp.Model;

public sealed class PureQLQuery : OneOfBase<MainGroupedQuery, MainPlainQuery>
{
    public PureQLQuery(MainGroupedQuery value)
        : this((OneOf<MainGroupedQuery, MainPlainQuery>)value) { }

    public PureQLQuery(MainPlainQuery value)
        : this((OneOf<MainGroupedQuery, MainPlainQuery>)value) { }

    private PureQLQuery(OneOf<MainGroupedQuery, MainPlainQuery> input)
        : base(input) { }
}
