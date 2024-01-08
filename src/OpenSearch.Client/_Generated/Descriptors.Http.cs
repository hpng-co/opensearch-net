/* SPDX-License-Identifier: Apache-2.0
*
* The OpenSearch Contributors require contributions made to
* this file be licensed under the Apache-2.0 license or a
* compatible open source license.
*/
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//
// This file is automatically generated
// Please do not edit these files manually
// Run the following in the root of the repos:
//
//      *NIX        :   ./build.sh codegen
//      Windows     :   build.bat codegen
//
// -----------------------------------------------

using OpenSearch.Net.Specification.HttpApi;

namespace OpenSearch.Client;

public class HttpDeleteDescriptor
    : ArbitraryHttpRequestDescriptorBase<
        HttpDeleteDescriptor,
        HttpDeleteRequestParameters,
        IHttpDeleteRequest
    >,
        IHttpDeleteRequest
{
    public HttpDeleteDescriptor(string path)
        : base(path) { }
}

public class HttpGetDescriptor
    : ArbitraryHttpRequestDescriptorBase<
        HttpGetDescriptor,
        HttpGetRequestParameters,
        IHttpGetRequest
    >,
        IHttpGetRequest
{
    public HttpGetDescriptor(string path)
        : base(path) { }
}

public class HttpHeadDescriptor
    : ArbitraryHttpRequestDescriptorBase<
        HttpHeadDescriptor,
        HttpHeadRequestParameters,
        IHttpHeadRequest
    >,
        IHttpHeadRequest
{
    public HttpHeadDescriptor(string path)
        : base(path) { }
}

public class HttpPatchDescriptor
    : ArbitraryBodyHttpRequestDescriptorBase<
        HttpPatchDescriptor,
        HttpPatchRequestParameters,
        IHttpPatchRequest
    >,
        IHttpPatchRequest
{
    public HttpPatchDescriptor(string path)
        : base(path) { }
}

public class HttpPostDescriptor
    : ArbitraryBodyHttpRequestDescriptorBase<
        HttpPostDescriptor,
        HttpPostRequestParameters,
        IHttpPostRequest
    >,
        IHttpPostRequest
{
    public HttpPostDescriptor(string path)
        : base(path) { }
}

public class HttpPutDescriptor
    : ArbitraryBodyHttpRequestDescriptorBase<
        HttpPutDescriptor,
        HttpPutRequestParameters,
        IHttpPutRequest
    >,
        IHttpPutRequest
{
    public HttpPutDescriptor(string path)
        : base(path) { }
}