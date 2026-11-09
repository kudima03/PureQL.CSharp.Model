using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Parameters;

public interface IParameter
{
    public string Param { get; }

    public IType Type { get; }
}
