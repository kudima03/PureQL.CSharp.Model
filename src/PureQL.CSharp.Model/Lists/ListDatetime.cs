namespace PureQL.CSharp.Model.Lists;

/// <summary>PureQL <c>list.datetime</c>.</summary>
public readonly union ListDatetime(
    ListLiteralDatetime,
    ListParamDatetime,
    ListSubqueryColumnDatetime,
    ListSubqueryColumnDatetimeNullable
);
