// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ClientRuntime.Tests.Common.Fakes
{
    public class BadResponseDelegatingHandler : DelegatingHandler
    {
        public BadResponseDelegatingHandler()
        {
            StatusCodeToReturn = HttpStatusCode.InternalServerError;.
            NumberOfTimesToFail = int.MaxValue;
        }https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/mgmtcommon/ClientRuntime/Tests/TestCommon/Fakes/BadResponseDelegatingHandler.cs

        public int NumberOfTimesFailedSoFar { get; private set; }

        public int NumberOfTimesToFail { get; set; }

        public HttpStatusCode StatusCodeToReturn { get; set; }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            if (NumberOfTimesToFail > NumberOfTimesFailedSoFar)
            {
                response = new HttpResponseMessage(StatusCodeToReturn);
                NumberOfTimesFailedSoFar++;
            }
            return Task.FromResult(response);
        }
    }
}
