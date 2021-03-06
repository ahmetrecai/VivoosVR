﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// CustomerApi operations.
    /// </summary>
    public partial interface ICustomerApi
    {
        /// <param name='rcurrent'>
        /// </param>
        /// <param name='rrowCount'>
        /// </param>
        /// <param name='rsearchPhrase'>
        /// </param>
        /// <param name='rsortItemfield'>
        /// </param>
        /// <param name='rsortItemtype'>
        /// </param>
        /// <param name='rsortItemsortFunc'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<GetAllAssetsWithImagesResponse>> GetMyAssetsWithImagesWithHttpMessagesAsync(int? rcurrent = default(int?), int? rrowCount = default(int?), string rsearchPhrase = default(string), string rsortItemfield = default(string), string rsortItemtype = default(string), object rsortItemsortFunc = default(object), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='rcurrent'>
        /// </param>
        /// <param name='rrowCount'>
        /// </param>
        /// <param name='rsearchPhrase'>
        /// </param>
        /// <param name='rsortItemfield'>
        /// </param>
        /// <param name='rsortItemtype'>
        /// </param>
        /// <param name='rsortItemsortFunc'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<GetAllAssetsWithImagesResponse>> GetNotMyAssetsWithImagesWithHttpMessagesAsync(int? rcurrent = default(int?), int? rrowCount = default(int?), string rsearchPhrase = default(string), string rsortItemfield = default(string), string rsortItemtype = default(string), object rsortItemsortFunc = default(object), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<CoreApplicationUser>> GetCurrentUserWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
