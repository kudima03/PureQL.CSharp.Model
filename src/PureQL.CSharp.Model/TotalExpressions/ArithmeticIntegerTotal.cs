using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ArithmeticIntegerTotal
    : OneOfBase<
        AddIntegerTotal,
        SubtractIntegerTotal,
        MultiplyIntegerTotal,
        IntegerDivideIntegerTotal,
        ModuloIntegerTotal
    >
{
    public ArithmeticIntegerTotal(AddIntegerTotal value)
        : this(
            (OneOf<
                AddIntegerTotal,
                SubtractIntegerTotal,
                MultiplyIntegerTotal,
                IntegerDivideIntegerTotal,
                ModuloIntegerTotal
            >)
                value
        )
    { }

    public ArithmeticIntegerTotal(SubtractIntegerTotal value)
        : this(
            (OneOf<
                AddIntegerTotal,
                SubtractIntegerTotal,
                MultiplyIntegerTotal,
                IntegerDivideIntegerTotal,
                ModuloIntegerTotal
            >)
                value
        )
    { }

    public ArithmeticIntegerTotal(MultiplyIntegerTotal value)
        : this(
            (OneOf<
                AddIntegerTotal,
                SubtractIntegerTotal,
                MultiplyIntegerTotal,
                IntegerDivideIntegerTotal,
                ModuloIntegerTotal
            >)
                value
        )
    { }

    public ArithmeticIntegerTotal(IntegerDivideIntegerTotal value)
        : this(
            (OneOf<
                AddIntegerTotal,
                SubtractIntegerTotal,
                MultiplyIntegerTotal,
                IntegerDivideIntegerTotal,
                ModuloIntegerTotal
            >)
                value
        )
    { }

    public ArithmeticIntegerTotal(ModuloIntegerTotal value)
        : this(
            (OneOf<
                AddIntegerTotal,
                SubtractIntegerTotal,
                MultiplyIntegerTotal,
                IntegerDivideIntegerTotal,
                ModuloIntegerTotal
            >)
                value
        )
    { }

    private ArithmeticIntegerTotal(
        OneOf<
            AddIntegerTotal,
            SubtractIntegerTotal,
            MultiplyIntegerTotal,
            IntegerDivideIntegerTotal,
            ModuloIntegerTotal
        > input
    )
        : base(input) { }
}
