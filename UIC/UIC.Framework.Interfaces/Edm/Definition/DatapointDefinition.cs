using System;
using UIC.Framework.Interfaces.Util;

namespace UIC.Framework.Interfaces.Edm.Definition
{
    public interface DatapointDefinition
    {
        Guid Id { get; }
        string Key { get; }
        string Name { get; }
        string Description { get; }
        UicDataType DataType { get; }
    }
}