using PureQL.CSharp.Model.ArrayTypes;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ArrayParameters;

public sealed record DateTimeArrayParameter : IParameter
{
    public DateTimeArrayParameter(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IType Type => new DateTimeArrayType();
}
