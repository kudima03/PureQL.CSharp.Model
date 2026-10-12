using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ArithmeticDecimalNullableGroup
    : OneOfBase<
        AddDecimalNullableGroup,
        SubtractDecimalNullableGroup,
        MultiplyDecimalNullableGroup,
        DivideDecimalNullableGroup
    >
{
    public ArithmeticDecimalNullableGroup(AddDecimalNullableGroup value)
        : this(
            (OneOf<
                AddDecimalNullableGroup,
                SubtractDecimalNullableGroup,
                MultiplyDecimalNullableGroup,
                DivideDecimalNullableGroup
            >)
                value
        )
    { }

    public ArithmeticDecimalNullableGroup(SubtractDecimalNullableGroup value)
        : this(
            (OneOf<
                AddDecimalNullableGroup,
                SubtractDecimalNullableGroup,
                MultiplyDecimalNullableGroup,
                DivideDecimalNullableGroup
            >)
                value
        )
    { }

    public ArithmeticDecimalNullableGroup(MultiplyDecimalNullableGroup value)
        : this(
            (OneOf<
                AddDecimalNullableGroup,
                SubtractDecimalNullableGroup,
                MultiplyDecimalNullableGroup,
                DivideDecimalNullableGroup
            >)
                value
        )
    { }

    public ArithmeticDecimalNullableGroup(DivideDecimalNullableGroup value)
        : this(
            (OneOf<
                AddDecimalNullableGroup,
                SubtractDecimalNullableGroup,
                MultiplyDecimalNullableGroup,
                DivideDecimalNullableGroup
            >)
                value
        )
    { }

    private ArithmeticDecimalNullableGroup(
        OneOf<
            AddDecimalNullableGroup,
            SubtractDecimalNullableGroup,
            MultiplyDecimalNullableGroup,
            DivideDecimalNullableGroup
        > input
    )
        : base(input) { }
}
