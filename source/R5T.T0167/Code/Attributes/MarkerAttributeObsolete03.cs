using System;

using R5T.T0143;


namespace R5T.T0131
{
    /// <summary>
    /// Marker attribute that is just an example marker attribute.
    /// It's purpose in life is to be attributed with the <see cref="MarkerAttributeMarkerAttribute"/> for use in testing.
    /// </summary>
    [Obsolete("An obsolete marker attribute.")]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class MarkerAttributeObsolete03 : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsMarkerAttribute01;
        /// <summary>
        /// Allows specifying that a class is *not* a marker attribute 01 class.
        /// This is useful for marking classes that end up canonical marker attribute 01 code file locations, but are not marker attribute 01 classes.
        /// </summary>
        public bool IsMarkerAttribute01
        {
            get
            {
                return this.zIsMarkerAttribute01;
            }
        }


        public MarkerAttributeObsolete03(
            bool isMarkerAttribute01 = true)
        {
            this.zIsMarkerAttribute01 = isMarkerAttribute01;
        }
    }
}
