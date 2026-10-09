using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ArithmeticIntegerNullableGroup
    : OneOfBase<
        AddIntegerNullableGroup,
        SubtractIntegerNullableGroup,
        MultiplyIntegerNullableGroup,
        IntegerDivideIntegerNullableGroup,
        ModuloIntegerNullableGroup
    >
{
    public ArithmeticIntegerNullableGroup(AddIntegerNullableGroup value)
        : this(
            (OneOf<
                AddIntegerNullableGroup,
                SubtractIntegerNullableGroup,
                MultiplyIntegerNullableGroup,
                IntegerDivideIntegerNullableGroup,
                ModuloIntegerNullableGroup
            >)
                value
        )
    { }

    public ArithmeticIntegerNullableGroup(SubtractIntegerNullableGroup value)
        : this(
            (OneOf<
                AddIntegerNullableGroup,
                SubtractIntegerNullableGroup,
                MultiplyIntegerNullableGroup,
                IntegerDivideIntegerNullableGroup,
                ModuloIntegerNullableGroup
            >)
                value
        )
    { }

    public ArithmeticIntegerNullableGroup(MultiplyIntegerNullableGroup value)
        : this(
            (OneOf<
                AddIntegerNullableGroup,
                SubtractIntegerNullableGroup,
                MultiplyIntegerNullableGroup,
                IntegerDivideIntegerNullableGroup,
                ModuloIntegerNullableGroup
            >)
                value
        )
    { }

    public ArithmeticIntegerNullableGroup(IntegerDivideIntegerNullableGroup value)
        : this(
            (OneOf<
                AddIntegerNullableGroup,
                SubtractIntegerNullableGroup,
                MultiplyIntegerNullableGroup,
                IntegerDivideIntegerNullableGroup,
                ModuloIntegerNullableGroup
            >)
                value
        )
    { }

    public ArithmeticIntegerNullableGroup(ModuloIntegerNullableGroup value)
        : this(
            (OneOf<
                AddIntegerNullableGroup,
                SubtractIntegerNullableGroup,
                MultiplyIntegerNullableGroup,
                IntegerDivideIntegerNullableGroup,
                ModuloIntegerNullableGroup
            >)
                value
        )
    { }

    private ArithmeticIntegerNullableGroup(
        OneOf<
            AddIntegerNullableGroup,
            SubtractIntegerNullableGroup,
            MultiplyIntegerNullableGroup,
            IntegerDivideIntegerNullableGroup,
            ModuloIntegerNullableGroup
        > input
    )
        : base(input) { }
}
