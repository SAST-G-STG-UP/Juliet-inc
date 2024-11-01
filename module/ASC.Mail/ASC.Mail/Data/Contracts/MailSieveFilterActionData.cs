﻿/*
 *
 * (c) Copyright Ascensio System Limited 2010-2023
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
*/


using System;
using System.Runtime.Serialization;

using ASC.Mail.Enums.Filter;

namespace ASC.Mail.Data.Contracts
{
    [Serializable]
    [DataContract(Namespace = "", Name = "FilterAction")]
    public class MailSieveFilterActionData : IEquatable<MailSieveFilterActionData>
    {
        ///<example name="action" type="int">1</example>
        [DataMember(IsRequired = true, Name = "action")]
        public ActionType Action { get; set; }

        ///<example name="data">data</example>
        [DataMember(IsRequired = false, Name = "data")]
        public string Data { get; set; }

        public bool Equals(MailSieveFilterActionData other)
        {
            if (other == null) return false;

            return Action == other.Action && Data.Equals(other.Data);
        }

        public override int GetHashCode()
        {
            return Action.GetHashCode() ^ (Data ?? "").GetHashCode();
        }
    }
}
