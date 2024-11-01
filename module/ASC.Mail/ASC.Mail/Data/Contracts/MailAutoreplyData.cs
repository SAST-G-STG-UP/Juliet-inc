/*
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

namespace ASC.Mail.Data.Contracts
{
    [DataContract(Namespace = "")]
    public class MailAutoreplyData
    {
        public MailAutoreplyData(int mailboxId, int tenant, bool turnOn,
            bool onlyContacts, bool turnOnToDate, DateTime from, DateTime to, string subject, string html)
        {
            Tenant = tenant;
            MailboxId = mailboxId;
            TurnOn = turnOn;
            TurnOnToDate = turnOnToDate;
            OnlyContacts = onlyContacts;
            FromDate = from;
            ToDate = to;
            Subject = subject;
            Html = html;
        }

        public int Tenant { get; private set; }

        ///<example type="int" name="mailboxId">33</example>
        [DataMember(Name = "mailboxId")]
        public int MailboxId { get; private set; }

        ///<example name="turnOn">true</example>
        [DataMember(Name = "turnOn")]
        public bool TurnOn { get; set; }

        ///<example name="onlyContacts">false</example>
        [DataMember(Name = "onlyContacts")]
        public bool OnlyContacts { get; private set; }

        ///<example name="turnOnToDate">true</example>
        [DataMember(Name = "turnOnToDate")]
        public bool TurnOnToDate { get; private set; }

        ///<example name="fromDate">2020-10-01T17:04:32.0000000</example>
        [DataMember(Name = "fromDate")]
        public DateTime FromDate { get; private set; }

        ///<example name="toDate">2020-10-01T17:04:32.0000000</example>
        [DataMember(Name = "toDate")]
        public DateTime ToDate { get; private set; }

        ///<example name="subject">subject</example>
        [DataMember(Name = "subject")]
        public string Subject { get; private set; }

        ///<example name="html">html</example>
        [DataMember(Name = "html")]
        public string Html { get; private set; }
    }
}
