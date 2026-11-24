using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>declares.string.nullable@row</c>.</summary>
public readonly union DeclaresStringNullableRow(
    ConcatStringNullableRow,
    UpperStringNullableRow,
    LowerStringNullableRow,
    FoldCaseStringNullableRow,
    NormalizeStringNullableRow,
    RemoveDiacriticsStringNullableRow,
    TrimStringNullableRow,
    TrimStartStringNullableRow,
    TrimEndStringNullableRow,
    SubstringStringNullableRow,
    ReplaceStringNullableRow,
    SplitPartStringNullableRow,
    PadStartStringNullableRow,
    PadEndStringNullableRow,
    RepeatStringNullableRow,
    ReverseStringNullableRow,
    ExtractRegexRow,
    ReplaceRegexStringNullableRow,
    AsStringDecimalStringNullableRow,
    AsStringBooleanStringNullableRow,
    AsStringDateStringNullableRow,
    AsStringTimeStringNullableRow,
    AsStringDatetimeStringNullableRow,
    AsStringUuidStringNullableRow,
    AsNullableStringNullableRow,
    IfStringNullableRow,
    CoalesceStringNullableRow,
    NullIfEqualStringNullableRow,
    GreatestStringNullableRow,
    LeastStringNullableRow,
    LiteralStringNullable,
    ParamStringNullable,
    FieldStringNullable
);
