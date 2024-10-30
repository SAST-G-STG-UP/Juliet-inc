// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.IO;
using System.Net.Http;
using System.Threading;

using Microsoft.Graph;

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    /// <summary>
    /// The interface IItemContentRequest.
    /// </summary>
    public partial interface IItemContentRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the stream.
        /// </summary>
        /// <returns>The stream.</returns>
        System.Threading.Tasks.Task<Stream> GetAsync();

        /// <summary>
        /// Gets the stream.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <returns>The stream.</returns>
        System.Threading.Tasks.Task<Stream> GetAsync(CancellationToken cancellationToken, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead);


        /// <summary>
        /// PUTs the specified stream.
        /// </summary>
        /// <typeparam name="T">The type returned by the PUT call.</typeparam>
        /// <param name="content">The stream to PUT.</param>
        /// <returns>The object returned by the PUT call.</returns>
        System.Threading.Tasks.Task<T> PutAsync<T>(Stream content) where T : Item;

        /// <summary>
        /// PUTs the specified stream.
        /// </summary>
        /// <typeparam name="T">The type returned by the PUT call.</typeparam>
        /// <param name="content">The stream to PUT.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <returns>The object returned by the PUT call.</returns>
        System.Threading.Tasks.Task<T> PutAsync<T>(Stream content, CancellationToken cancellationToken, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead) where T : Item;

    }
}
