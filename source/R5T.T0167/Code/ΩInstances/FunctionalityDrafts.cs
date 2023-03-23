using System;


namespace R5T.T0167
{
    public class FunctionalityDrafts : IFunctionalityDrafts
    {
        #region Infrastructure

        public static IFunctionalityDrafts Instance { get; } = new FunctionalityDrafts();


        private FunctionalityDrafts()
        {
        }

        #endregion
    }
}
