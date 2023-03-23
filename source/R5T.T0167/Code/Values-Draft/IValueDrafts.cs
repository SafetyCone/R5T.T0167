using System;

using R5T.T0131;


namespace R5T.T0167
{
    /// <summary>
    /// Functions for testing purposes.
    /// </summary>
    [DraftValuesMarker]
    public partial interface IValueDrafts : IDraftValuesMarker
    {
        /// <summary>
        /// A draft value.
        /// </summary>
        public string ValueDraft01 => "Value01";

        /// <summary>
        /// An obsolete draft value.
        /// </summary>
        [Obsolete("An obsolete value.")]
        public string ValueDraftObsolete02 => "Value02";
    }
}
