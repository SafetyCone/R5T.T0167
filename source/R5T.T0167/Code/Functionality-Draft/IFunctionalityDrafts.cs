using System;

using R5T.T0132;


namespace R5T.T0167
{
    /// <summary>
    /// Function drafts for testing purposes.
    /// </summary>
    [DraftFunctionalityMarker]
    public partial interface IFunctionalityDrafts : IDraftFunctionalityMarker
    {
        public void FunctionDraft01()
        {
            throw new NotImplementedException();
        }

        [Obsolete("An obsolete exploration.")]
        public void ObsoleteFunctionDraft02()
        {
            throw new NotImplementedException();
        }
    }
}
