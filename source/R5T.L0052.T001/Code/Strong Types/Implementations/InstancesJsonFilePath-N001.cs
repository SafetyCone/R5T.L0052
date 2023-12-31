using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0052.T001.N001
{
    /// <inheritdoc cref="IInstancesJsonFilePath"/>
    [StrongTypeImplementationMarker]
    public class InstancesJsonFilePath : TypedBase<string>, IStrongTypeMarker,
        IInstancesJsonFilePath
    {
        public InstancesJsonFilePath(string value)
            : base(value)
        {
        }
    }
}