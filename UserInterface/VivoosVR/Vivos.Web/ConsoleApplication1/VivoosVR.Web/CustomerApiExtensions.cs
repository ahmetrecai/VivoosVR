﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ConsoleApplication1
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for CustomerApi.
    /// </summary>
    public static partial class CustomerApiExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            public static GetAllAssetsWithImagesResponse GetMyAssetsWithImages(this ICustomerApi operations, int? rcurrent = default(int?), int? rrowCount = default(int?), string rsearchPhrase = default(string), string rsortItemfield = default(string), string rsortItemtype = default(string), object rsortItemsortFunc = default(object))
            {
                return Task.Factory.StartNew(s => ((ICustomerApi)s).GetMyAssetsWithImagesAsync(rcurrent, rrowCount, rsearchPhrase, rsortItemfield, rsortItemtype, rsortItemsortFunc), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetAllAssetsWithImagesResponse> GetMyAssetsWithImagesAsync(this ICustomerApi operations, int? rcurrent = default(int?), int? rrowCount = default(int?), string rsearchPhrase = default(string), string rsortItemfield = default(string), string rsortItemtype = default(string), object rsortItemsortFunc = default(object), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetMyAssetsWithImagesWithHttpMessagesAsync(rcurrent, rrowCount, rsearchPhrase, rsortItemfield, rsortItemtype, rsortItemsortFunc, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            public static GetAllAssetsWithImagesResponse GetNotMyAssetsWithImages(this ICustomerApi operations, int? rcurrent = default(int?), int? rrowCount = default(int?), string rsearchPhrase = default(string), string rsortItemfield = default(string), string rsortItemtype = default(string), object rsortItemsortFunc = default(object))
            {
                return Task.Factory.StartNew(s => ((ICustomerApi)s).GetNotMyAssetsWithImagesAsync(rcurrent, rrowCount, rsearchPhrase, rsortItemfield, rsortItemtype, rsortItemsortFunc), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetAllAssetsWithImagesResponse> GetNotMyAssetsWithImagesAsync(this ICustomerApi operations, int? rcurrent = default(int?), int? rrowCount = default(int?), string rsearchPhrase = default(string), string rsortItemfield = default(string), string rsortItemtype = default(string), object rsortItemsortFunc = default(object), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNotMyAssetsWithImagesWithHttpMessagesAsync(rcurrent, rrowCount, rsearchPhrase, rsortItemfield, rsortItemtype, rsortItemsortFunc, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static CoreApplicationUser GetCurrentUser(this ICustomerApi operations)
            {
                return Task.Factory.StartNew(s => ((ICustomerApi)s).GetCurrentUserAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CoreApplicationUser> GetCurrentUserAsync(this ICustomerApi operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCurrentUserWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
