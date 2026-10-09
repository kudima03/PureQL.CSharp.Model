using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class ComparisonGroup
    : OneOfBase<
        EqualGroup,
        NotEqualGroup,
        InGroup,
        GreaterThanGroup,
        LessThanGroup,
        GreaterThanOrEqualGroup,
        LessThanOrEqualGroup
    >
{
    public ComparisonGroup(EqualGroup value)
        : this(
            (OneOf<
                EqualGroup,
                NotEqualGroup,
                InGroup,
                GreaterThanGroup,
                LessThanGroup,
                GreaterThanOrEqualGroup,
                LessThanOrEqualGroup
            >)
                value
        )
    { }

    public ComparisonGroup(NotEqualGroup value)
        : this(
            (OneOf<
                EqualGroup,
                NotEqualGroup,
                InGroup,
                GreaterThanGroup,
                LessThanGroup,
                GreaterThanOrEqualGroup,
                LessThanOrEqualGroup
            >)
                value
        )
    { }

    public ComparisonGroup(InGroup value)
        : this(
            (OneOf<
                EqualGroup,
                NotEqualGroup,
                InGroup,
                GreaterThanGroup,
                LessThanGroup,
                GreaterThanOrEqualGroup,
                LessThanOrEqualGroup
            >)
                value
        )
    { }

    public ComparisonGroup(GreaterThanGroup value)
        : this(
            (OneOf<
                EqualGroup,
                NotEqualGroup,
                InGroup,
                GreaterThanGroup,
                LessThanGroup,
                GreaterThanOrEqualGroup,
                LessThanOrEqualGroup
            >)
                value
        )
    { }

    public ComparisonGroup(LessThanGroup value)
        : this(
            (OneOf<
                EqualGroup,
                NotEqualGroup,
                InGroup,
                GreaterThanGroup,
                LessThanGroup,
                GreaterThanOrEqualGroup,
                LessThanOrEqualGroup
            >)
                value
        )
    { }

    public ComparisonGroup(GreaterThanOrEqualGroup value)
        : this(
            (OneOf<
                EqualGroup,
                NotEqualGroup,
                InGroup,
                GreaterThanGroup,
                LessThanGroup,
                GreaterThanOrEqualGroup,
                LessThanOrEqualGroup
            >)
                value
        )
    { }

    public ComparisonGroup(LessThanOrEqualGroup value)
        : this(
            (OneOf<
                EqualGroup,
                NotEqualGroup,
                InGroup,
                GreaterThanGroup,
                LessThanGroup,
                GreaterThanOrEqualGroup,
                LessThanOrEqualGroup
            >)
                value
        )
    { }

    private ComparisonGroup(
        OneOf<
            EqualGroup,
            NotEqualGroup,
            InGroup,
            GreaterThanGroup,
            LessThanGroup,
            GreaterThanOrEqualGroup,
            LessThanOrEqualGroup
        > input
    )
        : base(input) { }
}
