using System;

using R5T.T0131;


namespace R5T.T0167
{
    /// <summary>
    /// Functions for testing purposes.
    /// </summary>
    [ValuesMarker]
    public partial interface IValues : IValuesMarker
    {
        /// <summary>
        /// A value.
        /// </summary>
        public string Value01 => "Value01";

        /// <summary>
        /// An obsolete value.
        /// </summary>
        [Obsolete("An obsolete value.")]
        public string ValueObsolete02 => "Value02";
    }
}
