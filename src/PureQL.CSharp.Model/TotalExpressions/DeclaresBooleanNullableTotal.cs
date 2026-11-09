using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>declares.boolean.nullable@total</c>.</summary>
public readonly union DeclaresBooleanNullableTotal(
    IfBooleanNullableTotal,
    CoalesceBooleanNullableTotal,
    MinBooleanNullableTotal,
    MaxBooleanNullableTotal,
    LiteralBooleanNullable,
    ParamBooleanNullable
);
