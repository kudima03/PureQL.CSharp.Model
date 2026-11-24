using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>declares.string.nullable@total</c>.</summary>
public readonly union DeclaresStringNullableTotal(
    ConcatStringNullableTotal,
    UpperStringNullableTotal,
    LowerStringNullableTotal,
    FoldCaseStringNullableTotal,
    NormalizeStringNullableTotal,
    RemoveDiacriticsStringNullableTotal,
    TrimStringNullableTotal,
    TrimStartStringNullableTotal,
    TrimEndStringNullableTotal,
    SubstringStringNullableTotal,
    ReplaceStringNullableTotal,
    SplitPartStringNullableTotal,
    PadStartStringNullableTotal,
    PadEndStringNullableTotal,
    RepeatStringNullableTotal,
    ReverseStringNullableTotal,
    ExtractRegexTotal,
    ReplaceRegexStringNullableTotal,
    AsStringDecimalStringNullableTotal,
    AsStringBooleanStringNullableTotal,
    AsStringDateStringNullableTotal,
    AsStringTimeStringNullableTotal,
    AsStringDatetimeStringNullableTotal,
    AsStringUuidStringNullableTotal,
    AsNullableStringNullableTotal,
    IfStringNullableTotal,
    CoalesceStringNullableTotal,
    NullIfEqualStringNullableTotal,
    GreatestStringNullableTotal,
    LeastStringNullableTotal,
    MinStringNullableTotal,
    MaxStringNullableTotal,
    FirstStringNullableTotal,
    LastStringNullableTotal,
    PercentileDiscreteStringNullableTotal,
    ModeStringNullableTotal,
    LiteralStringNullable,
    ParamStringNullable
);
