namespace PureQL.CSharp.Model.Lists;

/// <summary>PureQL <c>list.decimal</c>.</summary>
public readonly union ListDecimal(
    ListLiteralDecimal,
    ListParamDecimal,
    ListSubqueryColumnDecimal,
    ListSubqueryColumnDecimalNullable,
    ListLiteralInteger,
    ListParamInteger,
    ListSubqueryColumnInteger,
    ListSubqueryColumnIntegerNullable
);
