using System;


namespace R5T.T0167.Construction
{
    public class Operations : IOperations
    {
        #region Infrastructure

        public static IOperations Instance { get; } = new Operations();


        private Operations()
        {
        }

        #endregion
    }
}
