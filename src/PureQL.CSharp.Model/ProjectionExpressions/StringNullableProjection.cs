using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class StringNullableProjection
    : OneOfBase<StringProjection, ExactStringNullableProjection>
{
    public StringNullableProjection(StringProjection value)
        : this((OneOf<StringProjection, ExactStringNullableProjection>)value) { }

    public StringNullableProjection(ExactStringNullableProjection value)
        : this((OneOf<StringProjection, ExactStringNullableProjection>)value) { }

    private StringNullableProjection(
        OneOf<StringProjection, ExactStringNullableProjection> input
    )
        : base(input) { }
}
