// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph;

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    /// <summary>
    /// The type ItemDeltaCollectionPage.
    /// </summary>
    public partial class ItemDeltaCollectionPage : CollectionPage<Item>, IItemDeltaCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IItemDeltaRequest"/> instance.
        /// </summary>
        public IItemDeltaRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Gets or sets the Token.
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets the DeltaLink.
        /// </summary>
        public string DeltaLink { get; set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new ItemDeltaRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
