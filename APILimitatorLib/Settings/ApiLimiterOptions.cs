using System;
using System.Collections.Generic;
using System.Text;

namespace APILimitatorLib.Settings
{
    public class ApiLimiterOptions
    {
        public ApiLimiterOptions()
        {
            FilterMode = FilterModeType.AllFiltered;
            DefaultCallLimit = 100;
            DefaultTimeRangeLimit = 60000;
        }

        #region Embedded Classes

        public enum FilterModeType
        {
            AllAllowed = 0,
            AllFiltered = 1
        }

        #endregion

        #region Properties

        internal FilterModeType FilterMode
        {
            get;
            set;
        }

        internal long DefaultCallLimit
        {
            get;
            set;
        }

        internal long DefaultTimeRangeLimit
        {
            get;
            set;
        }

        #endregion
    }
}
