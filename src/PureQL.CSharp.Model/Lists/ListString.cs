namespace PureQL.CSharp.Model.Lists;

/// <summary>PureQL <c>list.string</c>.</summary>
public readonly union ListString(
    ListLiteralString,
    ListParamString,
    ListSubqueryColumnString,
    ListSubqueryColumnStringNullable
);
