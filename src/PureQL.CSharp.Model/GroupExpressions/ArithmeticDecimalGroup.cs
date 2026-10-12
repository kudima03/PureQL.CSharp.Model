using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ArithmeticDecimalGroup
    : OneOfBase<
        AddDecimalGroup,
        SubtractDecimalGroup,
        MultiplyDecimalGroup,
        DivideDecimalGroup
    >
{
    public ArithmeticDecimalGroup(AddDecimalGroup value)
        : this(
            (OneOf<
                AddDecimalGroup,
                SubtractDecimalGroup,
                MultiplyDecimalGroup,
                DivideDecimalGroup
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
                DivideDecimalGroup
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
                DivideDecimalGroup
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
                DivideDecimalGroup
            >)
                value
        )
    { }

    private ArithmeticDecimalGroup(
        OneOf<
            AddDecimalGroup,
            SubtractDecimalGroup,
            MultiplyDecimalGroup,
            DivideDecimalGroup
        > input
    )
        : base(input) { }
}
