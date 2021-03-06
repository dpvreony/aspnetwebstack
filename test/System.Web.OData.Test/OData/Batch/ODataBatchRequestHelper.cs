﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Net.Http;

namespace System.Web.OData.Test
{
    internal class ODataBatchRequestHelper
    {
        public static HttpMessageContent CreateODataRequestContent(HttpRequestMessage request)
        {
            var changeSetMessageContent = new HttpMessageContent(request);
            changeSetMessageContent.Headers.ContentType.Parameters.Clear();
            changeSetMessageContent.Headers.TryAddWithoutValidation("Content-Transfer-Encoding", "binary");
            return changeSetMessageContent;
        }
    }
}