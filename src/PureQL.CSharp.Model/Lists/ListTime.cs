using OneOf;

namespace PureQL.CSharp.Model.Lists;

public sealed class ListTime
    : OneOfBase<ListLiteralTime, ListParamTime, ListSubqueryColumnTime>
{
    public ListTime(ListLiteralTime value)
        : this((OneOf<ListLiteralTime, ListParamTime, ListSubqueryColumnTime>)value) { }

    public ListTime(ListParamTime value)
        : this((OneOf<ListLiteralTime, ListParamTime, ListSubqueryColumnTime>)value) { }

    public ListTime(ListSubqueryColumnTime value)
        : this((OneOf<ListLiteralTime, ListParamTime, ListSubqueryColumnTime>)value) { }

    private ListTime(OneOf<ListLiteralTime, ListParamTime, ListSubqueryColumnTime> input)
        : base(input) { }
}
