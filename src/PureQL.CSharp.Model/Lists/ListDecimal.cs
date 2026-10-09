using OneOf;

namespace PureQL.CSharp.Model.Lists;

public sealed class ListDecimal
    : OneOfBase<
        ListLiteralDecimal,
        ListParamDecimal,
        ListSubqueryColumnDecimal,
        ListInteger
    >
{
    public ListDecimal(ListLiteralDecimal value)
        : this(
            (OneOf<
                ListLiteralDecimal,
                ListParamDecimal,
                ListSubqueryColumnDecimal,
                ListInteger
            >)
                value
        )
    { }

    public ListDecimal(ListParamDecimal value)
        : this(
            (OneOf<
                ListLiteralDecimal,
                ListParamDecimal,
                ListSubqueryColumnDecimal,
                ListInteger
            >)
                value
        )
    { }

    public ListDecimal(ListSubqueryColumnDecimal value)
        : this(
            (OneOf<
                ListLiteralDecimal,
                ListParamDecimal,
                ListSubqueryColumnDecimal,
                ListInteger
            >)
                value
        )
    { }

    public ListDecimal(ListInteger value)
        : this(
            (OneOf<
                ListLiteralDecimal,
                ListParamDecimal,
                ListSubqueryColumnDecimal,
                ListInteger
            >)
                value
        )
    { }

    private ListDecimal(
        OneOf<
            ListLiteralDecimal,
            ListParamDecimal,
            ListSubqueryColumnDecimal,
            ListInteger
        > input
    )
        : base(input) { }
}
