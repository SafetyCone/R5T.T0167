using System;

using R5T.T0141;


namespace R5T.T0167
{
    /// <summary>
    /// Experiment drafts for testing purposes.
    /// </summary>
    [DraftExperimentsMarker]
    public partial interface IExperimentDrafts : IDraftExperimentsMarker
    {
        public void ExperimentDraft01()
        {
            throw new NotImplementedException();
        }

        [Obsolete("An obsolete experiment draft.")]
        public void ObsoleteExperimentDrafts02()
        {
            throw new NotImplementedException();
        }
    }
}
