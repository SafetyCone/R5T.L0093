using System;


namespace R5T.L0093.O000
{
    public class HasFilePathContextOperations : IHasFilePathContextOperations
    {
        #region Infrastructure

        public static IHasFilePathContextOperations Instance { get; } = new HasFilePathContextOperations();


        private HasFilePathContextOperations()
        {
        }

        #endregion
    }
}
