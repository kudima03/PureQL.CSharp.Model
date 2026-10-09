using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ArithmeticIntegerProjection
    : OneOfBase<
        AddIntegerProjection,
        SubtractIntegerProjection,
        MultiplyIntegerProjection,
        IntegerDivideIntegerProjection,
        ModuloIntegerProjection
    >
{
    public ArithmeticIntegerProjection(AddIntegerProjection value)
        : this(
            (OneOf<
                AddIntegerProjection,
                SubtractIntegerProjection,
                MultiplyIntegerProjection,
                IntegerDivideIntegerProjection,
                ModuloIntegerProjection
            >)
                value
        )
    { }

    public ArithmeticIntegerProjection(SubtractIntegerProjection value)
        : this(
            (OneOf<
                AddIntegerProjection,
                SubtractIntegerProjection,
                MultiplyIntegerProjection,
                IntegerDivideIntegerProjection,
                ModuloIntegerProjection
            >)
                value
        )
    { }

    public ArithmeticIntegerProjection(MultiplyIntegerProjection value)
        : this(
            (OneOf<
                AddIntegerProjection,
                SubtractIntegerProjection,
                MultiplyIntegerProjection,
                IntegerDivideIntegerProjection,
                ModuloIntegerProjection
            >)
                value
        )
    { }

    public ArithmeticIntegerProjection(IntegerDivideIntegerProjection value)
        : this(
            (OneOf<
                AddIntegerProjection,
                SubtractIntegerProjection,
                MultiplyIntegerProjection,
                IntegerDivideIntegerProjection,
                ModuloIntegerProjection
            >)
                value
        )
    { }

    public ArithmeticIntegerProjection(ModuloIntegerProjection value)
        : this(
            (OneOf<
                AddIntegerProjection,
                SubtractIntegerProjection,
                MultiplyIntegerProjection,
                IntegerDivideIntegerProjection,
                ModuloIntegerProjection
            >)
                value
        )
    { }

    private ArithmeticIntegerProjection(
        OneOf<
            AddIntegerProjection,
            SubtractIntegerProjection,
            MultiplyIntegerProjection,
            IntegerDivideIntegerProjection,
            ModuloIntegerProjection
        > input
    )
        : base(input) { }
}
