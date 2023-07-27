using System;


namespace R5T.L0052.T001.N001.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="T001.Extensions.IStringOperator.ToInstancesJsonFilePath(string)"/>
        public static IInstancesJsonFilePath ToInstancesJsonFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToInstancesJsonFilePath(value);
        }
    }
}
