using OneOf;

namespace PureQL.CSharp.Model.Lists;

public sealed class ListInteger
    : OneOfBase<ListLiteralInteger, ListParamInteger, ListSubqueryColumnInteger>
{
    public ListInteger(ListLiteralInteger value)
        : this(
            (OneOf<ListLiteralInteger, ListParamInteger, ListSubqueryColumnInteger>)value
        )
    { }

    public ListInteger(ListParamInteger value)
        : this(
            (OneOf<ListLiteralInteger, ListParamInteger, ListSubqueryColumnInteger>)value
        )
    { }

    public ListInteger(ListSubqueryColumnInteger value)
        : this(
            (OneOf<ListLiteralInteger, ListParamInteger, ListSubqueryColumnInteger>)value
        )
    { }

    private ListInteger(
        OneOf<ListLiteralInteger, ListParamInteger, ListSubqueryColumnInteger> input
    )
        : base(input) { }
}
