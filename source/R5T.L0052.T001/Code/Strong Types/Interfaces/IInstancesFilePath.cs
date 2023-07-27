using System;

using R5T.T0178;


namespace R5T.L0052.T001
{
    /// <summary>
    /// Strongly-types a string as the path an instances file (JSON formatted).
    /// </summary>
    [StrongTypeMarker]
    public interface IInstancesFilePath : IStrongTypeMarker,
        N001.IInstancesJsonFilePath
    {
    }
}