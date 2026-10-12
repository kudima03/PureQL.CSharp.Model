using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ArithmeticDecimalProjection
    : OneOfBase<
        AddDecimalProjection,
        SubtractDecimalProjection,
        MultiplyDecimalProjection,
        DivideDecimalProjection
    >
{
    public ArithmeticDecimalProjection(AddDecimalProjection value)
        : this(
            (OneOf<
                AddDecimalProjection,
                SubtractDecimalProjection,
                MultiplyDecimalProjection,
                DivideDecimalProjection
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
                DivideDecimalProjection
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
                DivideDecimalProjection
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
                DivideDecimalProjection
            >)
                value
        )
    { }

    private ArithmeticDecimalProjection(
        OneOf<
            AddDecimalProjection,
            SubtractDecimalProjection,
            MultiplyDecimalProjection,
            DivideDecimalProjection
        > input
    )
        : base(input) { }
}
