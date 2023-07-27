using System;


namespace R5T.L0052.T001.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToInstancesFilePath(string)"/>
        public static IInstancesFilePath ToInstancesFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToInstancesFilePath(value);
        }
    }
}
