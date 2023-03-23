using System;


namespace R5T.T0167
{
    public class ExperimentDrafts : IExperimentDrafts
    {
        #region Infrastructure

        public static IExperimentDrafts Instance { get; } = new ExperimentDrafts();


        private ExperimentDrafts()
        {
        }

        #endregion
    }
}
