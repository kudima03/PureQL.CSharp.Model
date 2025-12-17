using OneOf;
using PureQL.CSharp.Model.BooleanOperations;
using PureQL.CSharp.Model.Equalities;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class BooleanReturning
    : OneOfBase<BooleanField, BooleanParameter, BooleanScalar, Equality, BooleanOperator>
{
    public BooleanReturning(BooleanOperator booleanOperator)
        : this(
            (OneOf<
                BooleanField,
                BooleanParameter,
                BooleanScalar,
                Equality,
                BooleanOperator
            >)
                booleanOperator
        )
    { }

    public BooleanReturning(Equality field)
        : this(
            (OneOf<
                BooleanField,
                BooleanParameter,
                BooleanScalar,
                Equality,
                BooleanOperator
            >)
                field
        )
    { }

    public BooleanReturning(BooleanField field)
        : this(
            (OneOf<
                BooleanField,
                BooleanParameter,
                BooleanScalar,
                Equality,
                BooleanOperator
            >)
                field
        )
    { }

    public BooleanReturning(BooleanParameter parameter)
        : this(
            (OneOf<
                BooleanField,
                BooleanParameter,
                BooleanScalar,
                Equality,
                BooleanOperator
            >)
                parameter
        )
    { }

    public BooleanReturning(BooleanScalar scalar)
        : this(
            (OneOf<
                BooleanField,
                BooleanParameter,
                BooleanScalar,
                Equality,
                BooleanOperator
            >)
                scalar
        )
    { }

    private BooleanReturning(
        OneOf<
            BooleanField,
            BooleanParameter,
            BooleanScalar,
            Equality,
            BooleanOperator
        > input
    )
        : base(input) { }
}
