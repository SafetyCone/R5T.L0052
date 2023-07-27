using System;

using R5T.T0178;
using R5T.T0181;


namespace R5T.L0052.T001.N001
{
    /// <summary>
    /// Strongly-types a string as a the path of a file containing JSON-formatted instance data.
    /// </summary>
    [StrongTypeMarker]
    public interface IInstancesJsonFilePath : IStrongTypeMarker,
        IJsonFilePath
    {
    }
}