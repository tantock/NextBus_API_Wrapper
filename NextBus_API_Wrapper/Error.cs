using System;
using System.Collections.Generic;
using System.Text;

namespace NextBus_API_Wrapper
{
    class Error
    {
        bool _ShouldRetry;
        string _Message;

        public bool ShouldRetry
        {
            get { return _ShouldRetry; }
            set { _ShouldRetry = value; }
        }

        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }
    }
}
