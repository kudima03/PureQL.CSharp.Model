namespace PureQL.CSharp.Model.Lists;

/// <summary>PureQL <c>list.time</c>.</summary>
public readonly union ListTime(
    ListLiteralTime,
    ListParamTime,
    ListSubqueryColumnTime,
    ListSubqueryColumnTimeNullable
);
