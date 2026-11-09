using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>declares.date.nullable@row</c>.</summary>
public readonly union DeclaresDateNullableRow(
    DateAddDaysDateNullableRow,
    IfDateNullableRow,
    CoalesceDateNullableRow,
    LiteralDateNullable,
    ParamDateNullable,
    FieldDateNullable
);
