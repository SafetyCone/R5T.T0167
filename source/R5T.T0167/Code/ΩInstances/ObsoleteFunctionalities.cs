using System;


namespace R5T.T0167
{
    public class ObsoleteFunctionalities : IObsoleteFunctionalities
    {
        #region Infrastructure

        public static IObsoleteFunctionalities Instance { get; } = new ObsoleteFunctionalities();


        private ObsoleteFunctionalities()
        {
        }

        #endregion
    }
}
