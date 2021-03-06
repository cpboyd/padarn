#region License
// Copyright ©2017 Tacke Consulting (dba OpenNETCF)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
// and associated documentation files (the "Software"), to deal in the Software without restriction,
// including without limitation the rights to use, copy, modify, merge, publish, distribute, 
// sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is 
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or 
// substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR 
// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR 
// ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
#endregion
//                                                                   
// Copyright (c) 2007-2008 OpenNETCF Consulting, LLC                        
//    

using System.Net.Sockets;
using OpenNETCF.Web.Logging;

#if WindowsCE
using OpenNETCF.Web.Server.Ssl;
#else
using System.Net.Security;
#endif

namespace OpenNETCF.Web.Hosting
{
    /// <summary>
    /// Default handler for ASP.NET page requests for the Web Server
    /// </summary>
    public sealed class SslWorkerRequest : AsyncWorkerRequest
    {
        /// <summary>
        /// Returns a value indicating whether the connection uses SSL.
        /// </summary>
        /// <returns>true if the connection is an SSL connection; otherwise, false.</returns>
        public override bool IsSecure()
        {
            return true;
        }

        /// <summary>
        /// Initializes an instance of <see cref="SslWorkerRequest"/>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="stream"></param>
        /// <param name="logProvider"></param>
        internal SslWorkerRequest(TcpClient client, SslStream stream, ILogProvider logProvider)
            : base(client.Client, stream, logProvider)
        {
        }
    }
}
