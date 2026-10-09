using OneOf;

namespace PureQL.CSharp.Model.Lists;

public sealed class ListUuid
    : OneOfBase<ListLiteralUuid, ListParamUuid, ListSubqueryColumnUuid>
{
    public ListUuid(ListLiteralUuid value)
        : this((OneOf<ListLiteralUuid, ListParamUuid, ListSubqueryColumnUuid>)value) { }

    public ListUuid(ListParamUuid value)
        : this((OneOf<ListLiteralUuid, ListParamUuid, ListSubqueryColumnUuid>)value) { }

    public ListUuid(ListSubqueryColumnUuid value)
        : this((OneOf<ListLiteralUuid, ListParamUuid, ListSubqueryColumnUuid>)value) { }

    private ListUuid(OneOf<ListLiteralUuid, ListParamUuid, ListSubqueryColumnUuid> input)
        : base(input) { }
}
