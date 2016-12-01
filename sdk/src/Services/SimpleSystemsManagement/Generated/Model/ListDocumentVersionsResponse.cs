/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the ListDocumentVersions operation.
    /// </summary>
    public partial class ListDocumentVersionsResponse : AmazonWebServiceResponse
    {
        private List<DocumentVersionInfo> _documentVersions = new List<DocumentVersionInfo>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DocumentVersions. 
        /// <para>
        /// The document versions.
        /// </para>
        /// </summary>
        public List<DocumentVersionInfo> DocumentVersions
        {
            get { return this._documentVersions; }
            set { this._documentVersions = value; }
        }

        // Check to see if DocumentVersions property is set
        internal bool IsSetDocumentVersions()
        {
            return this._documentVersions != null && this._documentVersions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use when requesting the next set of items. If there are no additional
        /// items to return, the string is empty.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}