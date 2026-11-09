namespace PureQL.CSharp.Model.Lists;

/// <summary>PureQL <c>list.date</c>.</summary>
public readonly union ListDate(
    ListLiteralDate,
    ListParamDate,
    ListSubqueryColumnDate,
    ListSubqueryColumnDateNullable
);
