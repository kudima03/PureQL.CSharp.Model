using OneOf;

namespace PureQL.CSharp.Model.Lists;

public sealed class ListDate
    : OneOfBase<ListLiteralDate, ListParamDate, ListSubqueryColumnDate>
{
    public ListDate(ListLiteralDate value)
        : this((OneOf<ListLiteralDate, ListParamDate, ListSubqueryColumnDate>)value) { }

    public ListDate(ListParamDate value)
        : this((OneOf<ListLiteralDate, ListParamDate, ListSubqueryColumnDate>)value) { }

    public ListDate(ListSubqueryColumnDate value)
        : this((OneOf<ListLiteralDate, ListParamDate, ListSubqueryColumnDate>)value) { }

    private ListDate(OneOf<ListLiteralDate, ListParamDate, ListSubqueryColumnDate> input)
        : base(input) { }
}
