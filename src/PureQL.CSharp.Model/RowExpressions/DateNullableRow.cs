using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>date.nullable@row</c>.</summary>
public readonly union DateNullableRow(
    DateAddDaysDateRow,
    IfDateRow,
    CoalesceDateRow,
    LiteralDate,
    ParamDate,
    FieldDate,
    DateAddDaysDateNullableRow,
    IfDateNullableRow,
    CoalesceDateNullableRow,
    LiteralDateNullable,
    ParamDateNullable,
    FieldDateNullable
);
