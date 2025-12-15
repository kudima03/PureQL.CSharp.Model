using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model;

public interface IParameter
{
    public string Name { get; }

    public IType Type { get; }
}
