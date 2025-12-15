using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class DateReturning : OneOfBase<DateField, DateParameter, DateScalar>
{
    public DateReturning(DateField field)
        : this((OneOf<DateField, DateParameter, DateScalar>)field) { }

    public DateReturning(DateParameter parameter)
        : this((OneOf<DateField, DateParameter, DateScalar>)parameter) { }

    public DateReturning(DateScalar scalar)
        : this((OneOf<DateField, DateParameter, DateScalar>)scalar) { }

    private DateReturning(OneOf<DateField, DateParameter, DateScalar> input)
        : base(input) { }
}
