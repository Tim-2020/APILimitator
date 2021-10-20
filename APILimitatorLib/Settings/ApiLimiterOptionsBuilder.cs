using System;
using System.Collections.Generic;
using System.Text;

namespace APILimitatorLib.Settings
{
    public class ApiLimiterOptionsBuilder
    {
        public ApiLimiterOptionsBuilder()
        {
            m_ApiLimiterOptions = new ApiLimiterOptions();
        }

        #region Fields

        private readonly ApiLimiterOptions m_ApiLimiterOptions;

        #endregion

        #region Public

        public ApiLimiterOptionsBuilder SetFilterMode(ApiLimiterOptions.FilterModeType FilterMode)
        {
            m_ApiLimiterOptions.FilterMode = FilterMode;
            return this;
        }

        public ApiLimiterOptionsBuilder SetDefaultCallLimit(long DefaultCallLimit)
        {
            m_ApiLimiterOptions.DefaultCallLimit = DefaultCallLimit;
            return this;
        }

        public ApiLimiterOptionsBuilder SetDefaultTimeRangeLimit(long DefaultTimeRangeLimit)
        {
            m_ApiLimiterOptions.DefaultTimeRangeLimit = DefaultTimeRangeLimit;
            return this;
        }

        #endregion

        #region Properties

        public ApiLimiterOptions Options
        {
            get
            {
                return m_ApiLimiterOptions;
            }
        }

        #endregion
    }
}
