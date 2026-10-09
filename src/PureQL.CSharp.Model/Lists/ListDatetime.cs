using OneOf;

namespace PureQL.CSharp.Model.Lists;

public sealed class ListDatetime
    : OneOfBase<ListLiteralDatetime, ListParamDatetime, ListSubqueryColumnDatetime>
{
    public ListDatetime(ListLiteralDatetime value)
        : this(
            (OneOf<ListLiteralDatetime, ListParamDatetime, ListSubqueryColumnDatetime>)
                value
        )
    { }

    public ListDatetime(ListParamDatetime value)
        : this(
            (OneOf<ListLiteralDatetime, ListParamDatetime, ListSubqueryColumnDatetime>)
                value
        )
    { }

    public ListDatetime(ListSubqueryColumnDatetime value)
        : this(
            (OneOf<ListLiteralDatetime, ListParamDatetime, ListSubqueryColumnDatetime>)
                value
        )
    { }

    private ListDatetime(
        OneOf<ListLiteralDatetime, ListParamDatetime, ListSubqueryColumnDatetime> input
    )
        : base(input) { }
}
