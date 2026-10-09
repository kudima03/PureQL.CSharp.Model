using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ArithmeticIntegerGroup
    : OneOfBase<
        AddIntegerGroup,
        SubtractIntegerGroup,
        MultiplyIntegerGroup,
        IntegerDivideIntegerGroup,
        ModuloIntegerGroup
    >
{
    public ArithmeticIntegerGroup(AddIntegerGroup value)
        : this(
            (OneOf<
                AddIntegerGroup,
                SubtractIntegerGroup,
                MultiplyIntegerGroup,
                IntegerDivideIntegerGroup,
                ModuloIntegerGroup
            >)
                value
        )
    { }

    public ArithmeticIntegerGroup(SubtractIntegerGroup value)
        : this(
            (OneOf<
                AddIntegerGroup,
                SubtractIntegerGroup,
                MultiplyIntegerGroup,
                IntegerDivideIntegerGroup,
                ModuloIntegerGroup
            >)
                value
        )
    { }

    public ArithmeticIntegerGroup(MultiplyIntegerGroup value)
        : this(
            (OneOf<
                AddIntegerGroup,
                SubtractIntegerGroup,
                MultiplyIntegerGroup,
                IntegerDivideIntegerGroup,
                ModuloIntegerGroup
            >)
                value
        )
    { }

    public ArithmeticIntegerGroup(IntegerDivideIntegerGroup value)
        : this(
            (OneOf<
                AddIntegerGroup,
                SubtractIntegerGroup,
                MultiplyIntegerGroup,
                IntegerDivideIntegerGroup,
                ModuloIntegerGroup
            >)
                value
        )
    { }

    public ArithmeticIntegerGroup(ModuloIntegerGroup value)
        : this(
            (OneOf<
                AddIntegerGroup,
                SubtractIntegerGroup,
                MultiplyIntegerGroup,
                IntegerDivideIntegerGroup,
                ModuloIntegerGroup
            >)
                value
        )
    { }

    private ArithmeticIntegerGroup(
        OneOf<
            AddIntegerGroup,
            SubtractIntegerGroup,
            MultiplyIntegerGroup,
            IntegerDivideIntegerGroup,
            ModuloIntegerGroup
        > input
    )
        : base(input) { }
}
