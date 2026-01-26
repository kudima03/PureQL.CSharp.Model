using OneOf;
using PureQL.CSharp.Model.BooleanOperations;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class BooleanReturning
    : OneOfBase<
        BooleanParameter,
        BooleanScalar,
        Equality,
        BooleanOperator,
        Comparisons.Comparison
    >
{
    public BooleanReturning(BooleanOperator booleanOperator)
        : this(
            (OneOf<
                BooleanParameter,
                BooleanScalar,
                Equality,
                BooleanOperator,
                Comparisons.Comparison
            >)
                booleanOperator
        )
    { }

    public BooleanReturning(Equality field)
        : this(
            (OneOf<
                BooleanParameter,
                BooleanScalar,
                Equality,
                BooleanOperator,
                Comparisons.Comparison
            >)
                field
        )
    { }

    public BooleanReturning(BooleanParameter parameter)
        : this(
            (OneOf<
                BooleanParameter,
                BooleanScalar,
                Equality,
                BooleanOperator,
                Comparisons.Comparison
            >)
                parameter
        )
    { }

    public BooleanReturning(BooleanScalar scalar)
        : this(
            (OneOf<
                BooleanParameter,
                BooleanScalar,
                Equality,
                BooleanOperator,
                Comparisons.Comparison
            >)
                scalar
        )
    { }

    public BooleanReturning(Comparisons.Comparison comparison)
        : this(
            (OneOf<
                BooleanParameter,
                BooleanScalar,
                Equality,
                BooleanOperator,
                Comparisons.Comparison
            >)
                comparison
        )
    { }

    private BooleanReturning(
        OneOf<
            BooleanParameter,
            BooleanScalar,
            Equality,
            BooleanOperator,
            Comparisons.Comparison
        > input
    )
        : base(input) { }
}
