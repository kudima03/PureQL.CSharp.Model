using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ArithmeticDecimalProjection
    : OneOfBase<
        AddDecimalProjection,
        SubtractDecimalProjection,
        MultiplyDecimalProjection,
        DivideDecimalProjection,
        IntegerDivideIntegerProjection,
        ModuloIntegerProjection
    >
{
    public ArithmeticDecimalProjection(AddDecimalProjection value)
        : this(
            (OneOf<
                AddDecimalProjection,
                SubtractDecimalProjection,
                MultiplyDecimalProjection,
                DivideDecimalProjection,
                IntegerDivideIntegerProjection,
                ModuloIntegerProjection
            >)
                value
        )
    { }

    public ArithmeticDecimalProjection(SubtractDecimalProjection value)
        : this(
            (OneOf<
                AddDecimalProjection,
                SubtractDecimalProjection,
                MultiplyDecimalProjection,
                DivideDecimalProjection,
                IntegerDivideIntegerProjection,
                ModuloIntegerProjection
            >)
                value
        )
    { }

    public ArithmeticDecimalProjection(MultiplyDecimalProjection value)
        : this(
            (OneOf<
                AddDecimalProjection,
                SubtractDecimalProjection,
                MultiplyDecimalProjection,
                DivideDecimalProjection,
                IntegerDivideIntegerProjection,
                ModuloIntegerProjection
            >)
                value
        )
    { }

    public ArithmeticDecimalProjection(DivideDecimalProjection value)
        : this(
            (OneOf<
                AddDecimalProjection,
                SubtractDecimalProjection,
                MultiplyDecimalProjection,
                DivideDecimalProjection,
                IntegerDivideIntegerProjection,
                ModuloIntegerProjection
            >)
                value
        )
    { }

    public ArithmeticDecimalProjection(IntegerDivideIntegerProjection value)
        : this(
            (OneOf<
                AddDecimalProjection,
                SubtractDecimalProjection,
                MultiplyDecimalProjection,
                DivideDecimalProjection,
                IntegerDivideIntegerProjection,
                ModuloIntegerProjection
            >)
                value
        )
    { }

    public ArithmeticDecimalProjection(ModuloIntegerProjection value)
        : this(
            (OneOf<
                AddDecimalProjection,
                SubtractDecimalProjection,
                MultiplyDecimalProjection,
                DivideDecimalProjection,
                IntegerDivideIntegerProjection,
                ModuloIntegerProjection
            >)
                value
        )
    { }

    private ArithmeticDecimalProjection(
        OneOf<
            AddDecimalProjection,
            SubtractDecimalProjection,
            MultiplyDecimalProjection,
            DivideDecimalProjection,
            IntegerDivideIntegerProjection,
            ModuloIntegerProjection
        > input
    )
        : base(input) { }
}
