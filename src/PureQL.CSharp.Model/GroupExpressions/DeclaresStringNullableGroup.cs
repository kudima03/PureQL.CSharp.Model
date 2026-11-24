using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>declares.string.nullable@group</c>.</summary>
public readonly union DeclaresStringNullableGroup(
    ConcatStringNullableGroup,
    UpperStringNullableGroup,
    LowerStringNullableGroup,
    FoldCaseStringNullableGroup,
    NormalizeStringNullableGroup,
    RemoveDiacriticsStringNullableGroup,
    TrimStringNullableGroup,
    TrimStartStringNullableGroup,
    TrimEndStringNullableGroup,
    SubstringStringNullableGroup,
    ReplaceStringNullableGroup,
    SplitPartStringNullableGroup,
    PadStartStringNullableGroup,
    PadEndStringNullableGroup,
    RepeatStringNullableGroup,
    ReverseStringNullableGroup,
    ExtractRegexGroup,
    ReplaceRegexStringNullableGroup,
    AsStringDecimalStringNullableGroup,
    AsStringBooleanStringNullableGroup,
    AsStringDateStringNullableGroup,
    AsStringTimeStringNullableGroup,
    AsStringDatetimeStringNullableGroup,
    AsStringUuidStringNullableGroup,
    AsNullableStringNullableGroup,
    IfStringNullableGroup,
    CoalesceStringNullableGroup,
    NullIfEqualStringNullableGroup,
    GreatestStringNullableGroup,
    LeastStringNullableGroup,
    MinStringNullableGroup,
    MaxStringNullableGroup,
    FirstStringNullableGroup,
    LastStringNullableGroup,
    PercentileDiscreteStringNullableGroup,
    ModeStringNullableGroup,
    LiteralStringNullable,
    ParamStringNullable,
    KeyStringNullable
);
