﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GoogleApi.Entities.Search.Common.Response
{
    /// <summary>
    /// Metadata about the particular search engine that was used for performing the search query.
    /// </summary>
    [DataContract]
    public class Context
    {
        /// <summary>
        /// The name of the search engine that was used for the query.
        /// </summary>
        [DataMember(Name = "title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// A set of facet objects (refinements) you can use for refining a search.
        /// https://developers.google.com/custom-search/docs/refinements#create
        /// </summary>
        [DataMember(Name = "facets")]
        public virtual IEnumerable<Facet> Facets { get; set; }
    }
}