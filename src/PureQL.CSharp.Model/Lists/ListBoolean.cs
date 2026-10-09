using OneOf;

namespace PureQL.CSharp.Model.Lists;

public sealed class ListBoolean
    : OneOfBase<ListLiteralBoolean, ListParamBoolean, ListSubqueryColumnBoolean>
{
    public ListBoolean(ListLiteralBoolean value)
        : this(
            (OneOf<ListLiteralBoolean, ListParamBoolean, ListSubqueryColumnBoolean>)value
        )
    { }

    public ListBoolean(ListParamBoolean value)
        : this(
            (OneOf<ListLiteralBoolean, ListParamBoolean, ListSubqueryColumnBoolean>)value
        )
    { }

    public ListBoolean(ListSubqueryColumnBoolean value)
        : this(
            (OneOf<ListLiteralBoolean, ListParamBoolean, ListSubqueryColumnBoolean>)value
        )
    { }

    private ListBoolean(
        OneOf<ListLiteralBoolean, ListParamBoolean, ListSubqueryColumnBoolean> input
    )
        : base(input) { }
}
