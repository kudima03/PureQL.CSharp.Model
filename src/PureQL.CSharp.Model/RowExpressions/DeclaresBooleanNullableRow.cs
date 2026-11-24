using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>declares.boolean.nullable@row</c>.</summary>
public readonly union DeclaresBooleanNullableRow(
    AsBooleanBooleanNullableRow,
    AsNullableBooleanNullableRow,
    TryAsBooleanRow,
    IfBooleanNullableRow,
    CoalesceBooleanNullableRow,
    NullIfEqualBooleanNullableRow,
    GreatestBooleanNullableRow,
    LeastBooleanNullableRow,
    LiteralBooleanNullable,
    ParamBooleanNullable,
    FieldBooleanNullable
);
