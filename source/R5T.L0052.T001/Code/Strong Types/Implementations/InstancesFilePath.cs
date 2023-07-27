using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.L0052.T001
{
    /// <inheritdoc cref="IInstancesFilePath"/>
    [StrongTypeImplementationMarker]
    public class InstancesFilePath : TypedBase<string>, IStrongTypeMarker,
        IInstancesFilePath
    {
        public InstancesFilePath(string value)
            : base(value)
        {
        }
    }
}