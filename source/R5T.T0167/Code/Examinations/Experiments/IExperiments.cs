using System;

using R5T.T0141;


namespace R5T.T0167
{
    /// <summary>
    /// Experiments for testing purposes.
    /// </summary>
    [ExperimentsMarker]
    public partial interface IExperiments : IExperimentsMarker
    {
        public void Experiment01()
        {
            throw new NotImplementedException();
        }

        [Obsolete("An obsolete experiment.")]
        public void ObsoleteExperiment02()
        {
            throw new NotImplementedException();
        }
    }
}
