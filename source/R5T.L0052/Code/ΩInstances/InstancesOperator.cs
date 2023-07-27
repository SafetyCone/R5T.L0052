using System;


namespace R5T.L0052
{
    public class InstancesOperator : IInstancesOperator
    {
        #region Infrastructure

        public static IInstancesOperator Instance { get; } = new InstancesOperator();


        private InstancesOperator()
        {
        }

        #endregion
    }
}
