using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Lists;

public sealed record ListParamDecimal : IParameter
{
    public ListParamDecimal(string param)
    {
        Param = param;
    }

    public string Param { get; }

    public IType Type => new TypeDecimalList();
}
