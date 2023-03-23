using System;


namespace R5T.T0167
{
    public class DemonstrationDrafts : IDemonstrationDrafts
    {
        #region Infrastructure

        public static IDemonstrationDrafts Instance { get; } = new DemonstrationDrafts();


        private DemonstrationDrafts()
        {
        }

        #endregion
    }
}
