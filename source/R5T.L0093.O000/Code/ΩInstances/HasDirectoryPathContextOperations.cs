using System;


namespace R5T.L0093.O000
{
    public class HasDirectoryPathContextOperations : IHasDirectoryPathContextOperations
    {
        #region Infrastructure

        public static IHasDirectoryPathContextOperations Instance { get; } = new HasDirectoryPathContextOperations();


        private HasDirectoryPathContextOperations()
        {
        }

        #endregion
    }
}
