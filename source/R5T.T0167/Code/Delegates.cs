using System;

using R5T.T0155;


namespace R5T.T0167.Code
{
    /// <summary>
    /// A delegate for use in testing delegate survey.
    /// </summary>
    [DelegateMarker]
    public delegate int Delegate01(int a, int b);

    /// <summary>
    /// A draft delegate for use in testing delegate survey.
    /// </summary>
    [DraftDelegateMarker]
    public delegate int DelegateDraft01(int a, int b);

    /// <summary>
    /// An obsolete delegate for use in testing delegate survey.
    /// </summary>
    [DelegateMarker]
    public delegate int DelegateObsolete01(int a, int b);

    /// <summary>
    /// An obsolete draft delegate for use in testing delegate survey.
    /// </summary>
    [DraftDelegateMarker]
    public delegate int DelegateDraftObsolete01(int a, int b);
}
