using System;

using R5T.T0141;


namespace R5T.T0167
{
    /// <summary>
    /// Explorations for testing purposes.
    /// </summary>
    [ExplorationsMarker]
    public partial interface IExplorations : IExplorationsMarker
    {
        public void Exploration01()
        {
            throw new NotImplementedException();
        }

        [Obsolete("An obsolete exploration.")]
        public void ObsoleteExploration02()
        {
            throw new NotImplementedException();
        }
    }
}
