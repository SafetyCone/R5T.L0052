using System;
using R5T.T0132;


namespace R5T.L0052.T001.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IInstancesFilePath"/>
        public IInstancesFilePath ToInstancesFilePath(string value)
        {
            var output = new InstancesFilePath(value);
            return output;
        }

        /// <inheritdoc cref="N001.IInstancesJsonFilePath"/>
        public N001.IInstancesJsonFilePath ToInstancesJsonFilePath(string value)
        {
            var output = new N001.InstancesJsonFilePath(value);
            return output;
        }
    }
}
