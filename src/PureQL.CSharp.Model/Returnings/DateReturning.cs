using OneOf;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class DateReturning : OneOfBase<DateParameter, DateScalar>
{
    public DateReturning(DateParameter parameter)
        : this((OneOf<DateParameter, DateScalar>)parameter) { }

    public DateReturning(DateScalar scalar)
        : this((OneOf<DateParameter, DateScalar>)scalar) { }

    private DateReturning(OneOf<DateParameter, DateScalar> input)
        : base(input) { }
}
