using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ArithmeticDecimalNullableGroup
    : OneOfBase<
        AddDecimalNullableGroup,
        SubtractDecimalNullableGroup,
        MultiplyDecimalNullableGroup,
        DivideDecimalNullableGroup,
        IntegerDivideIntegerNullableGroup,
        ModuloIntegerNullableGroup
    >
{
    public ArithmeticDecimalNullableGroup(AddDecimalNullableGroup value)
        : this(
            (OneOf<
                AddDecimalNullableGroup,
                SubtractDecimalNullableGroup,
                MultiplyDecimalNullableGroup,
                DivideDecimalNullableGroup,
                IntegerDivideIntegerNullableGroup,
                ModuloIntegerNullableGroup
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
                DivideDecimalNullableGroup,
                IntegerDivideIntegerNullableGroup,
                ModuloIntegerNullableGroup
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
                DivideDecimalNullableGroup,
                IntegerDivideIntegerNullableGroup,
                ModuloIntegerNullableGroup
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
                DivideDecimalNullableGroup,
                IntegerDivideIntegerNullableGroup,
                ModuloIntegerNullableGroup
            >)
                value
        )
    { }

    public ArithmeticDecimalNullableGroup(IntegerDivideIntegerNullableGroup value)
        : this(
            (OneOf<
                AddDecimalNullableGroup,
                SubtractDecimalNullableGroup,
                MultiplyDecimalNullableGroup,
                DivideDecimalNullableGroup,
                IntegerDivideIntegerNullableGroup,
                ModuloIntegerNullableGroup
            >)
                value
        )
    { }

    public ArithmeticDecimalNullableGroup(ModuloIntegerNullableGroup value)
        : this(
            (OneOf<
                AddDecimalNullableGroup,
                SubtractDecimalNullableGroup,
                MultiplyDecimalNullableGroup,
                DivideDecimalNullableGroup,
                IntegerDivideIntegerNullableGroup,
                ModuloIntegerNullableGroup
            >)
                value
        )
    { }

    private ArithmeticDecimalNullableGroup(
        OneOf<
            AddDecimalNullableGroup,
            SubtractDecimalNullableGroup,
            MultiplyDecimalNullableGroup,
            DivideDecimalNullableGroup,
            IntegerDivideIntegerNullableGroup,
            ModuloIntegerNullableGroup
        > input
    )
        : base(input) { }
}
