using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ArithmeticDecimalGroup
    : OneOfBase<
        AddDecimalGroup,
        SubtractDecimalGroup,
        MultiplyDecimalGroup,
        DivideDecimalGroup,
        IntegerDivideIntegerGroup,
        ModuloIntegerGroup
    >
{
    public ArithmeticDecimalGroup(AddDecimalGroup value)
        : this(
            (OneOf<
                AddDecimalGroup,
                SubtractDecimalGroup,
                MultiplyDecimalGroup,
                DivideDecimalGroup,
                IntegerDivideIntegerGroup,
                ModuloIntegerGroup
            >)
                value
        )
    { }

    public ArithmeticDecimalGroup(SubtractDecimalGroup value)
        : this(
            (OneOf<
                AddDecimalGroup,
                SubtractDecimalGroup,
                MultiplyDecimalGroup,
                DivideDecimalGroup,
                IntegerDivideIntegerGroup,
                ModuloIntegerGroup
            >)
                value
        )
    { }

    public ArithmeticDecimalGroup(MultiplyDecimalGroup value)
        : this(
            (OneOf<
                AddDecimalGroup,
                SubtractDecimalGroup,
                MultiplyDecimalGroup,
                DivideDecimalGroup,
                IntegerDivideIntegerGroup,
                ModuloIntegerGroup
            >)
                value
        )
    { }

    public ArithmeticDecimalGroup(DivideDecimalGroup value)
        : this(
            (OneOf<
                AddDecimalGroup,
                SubtractDecimalGroup,
                MultiplyDecimalGroup,
                DivideDecimalGroup,
                IntegerDivideIntegerGroup,
                ModuloIntegerGroup
            >)
                value
        )
    { }

    public ArithmeticDecimalGroup(IntegerDivideIntegerGroup value)
        : this(
            (OneOf<
                AddDecimalGroup,
                SubtractDecimalGroup,
                MultiplyDecimalGroup,
                DivideDecimalGroup,
                IntegerDivideIntegerGroup,
                ModuloIntegerGroup
            >)
                value
        )
    { }

    public ArithmeticDecimalGroup(ModuloIntegerGroup value)
        : this(
            (OneOf<
                AddDecimalGroup,
                SubtractDecimalGroup,
                MultiplyDecimalGroup,
                DivideDecimalGroup,
                IntegerDivideIntegerGroup,
                ModuloIntegerGroup
            >)
                value
        )
    { }

    private ArithmeticDecimalGroup(
        OneOf<
            AddDecimalGroup,
            SubtractDecimalGroup,
            MultiplyDecimalGroup,
            DivideDecimalGroup,
            IntegerDivideIntegerGroup,
            ModuloIntegerGroup
        > input
    )
        : base(input) { }
}
