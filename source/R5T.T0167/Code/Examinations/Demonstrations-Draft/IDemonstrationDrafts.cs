using System;

using R5T.T0141;


namespace R5T.T0167
{
    /// <summary>
    /// Demonstration drafts for testing purposes.
    /// </summary>
    [DraftDemonstrationsMarker]
    public partial interface IDemonstrationDrafts : IDraftDemonstrationsMarker
    {
        public void DemonstrationDraft01()
        {
            throw new NotImplementedException();
        }

        [Obsolete("An obsolete demonstration draft.")]
        public void ObsoleteDemonstrationDraft02()
        {
            throw new NotImplementedException();
        }
    }
}
