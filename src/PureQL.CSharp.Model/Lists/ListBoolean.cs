namespace PureQL.CSharp.Model.Lists;

/// <summary>PureQL <c>list.boolean</c>.</summary>
public readonly union ListBoolean(
    ListLiteralBoolean,
    ListParamBoolean,
    ListSubqueryColumnBoolean,
    ListSubqueryColumnBooleanNullable
);
