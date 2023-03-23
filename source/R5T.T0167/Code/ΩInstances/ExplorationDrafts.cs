using System;


namespace R5T.T0167
{
    public class ExplorationDrafts : IExplorationDrafts
    {
        #region Infrastructure

        public static IExplorationDrafts Instance { get; } = new ExplorationDrafts();


        private ExplorationDrafts()
        {
        }

        #endregion
    }
}
