namespace PureQL.CSharp.Model.Lists;

/// <summary>PureQL <c>list.uuid</c>.</summary>
public readonly union ListUuid(
    ListLiteralUuid,
    ListParamUuid,
    ListSubqueryColumnUuid,
    ListSubqueryColumnUuidNullable
);
