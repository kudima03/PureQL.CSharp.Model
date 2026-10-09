using OneOf;

namespace PureQL.CSharp.Model.Lists;

public sealed class ListString
    : OneOfBase<ListLiteralString, ListParamString, ListSubqueryColumnString>
{
    public ListString(ListLiteralString value)
        : this((OneOf<ListLiteralString, ListParamString, ListSubqueryColumnString>)value)
    { }

    public ListString(ListParamString value)
        : this((OneOf<ListLiteralString, ListParamString, ListSubqueryColumnString>)value)
    { }

    public ListString(ListSubqueryColumnString value)
        : this((OneOf<ListLiteralString, ListParamString, ListSubqueryColumnString>)value)
    { }

    private ListString(
        OneOf<ListLiteralString, ListParamString, ListSubqueryColumnString> input
    )
        : base(input) { }
}
