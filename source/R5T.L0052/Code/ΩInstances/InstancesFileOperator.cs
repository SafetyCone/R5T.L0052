using System;


namespace R5T.L0052
{
    public class InstancesFileOperator : IInstancesFileOperator
    {
        #region Infrastructure

        public static IInstancesFileOperator Instance { get; } = new InstancesFileOperator();


        private InstancesFileOperator()
        {
        }

        #endregion
    }
}
