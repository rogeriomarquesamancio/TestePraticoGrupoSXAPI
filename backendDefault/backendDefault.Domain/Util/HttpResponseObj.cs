using System;

namespace backendDefault.Domain.Util
{
    public class HttpResponseObj
    {
        public bool svStatus { get; set; }
        public string msg { get; set; }
        public object data { get; set; }
        public object error { get; set; }

        public HttpResponseObj(string msg)
        {
            this.msg = msg;
            this.svStatus = false;
        }

        public HttpResponseObj(string msg, Exception ex)
        {
            this.msg = msg;
            this.error = ex;
            this.svStatus = false;
        }

        public HttpResponseObj(object data)
        {
            this.data = data;
            this.svStatus = data != null;
        }

        public HttpResponseObj(bool svStatus)
        {
            this.svStatus = svStatus;
        }
    }
}
