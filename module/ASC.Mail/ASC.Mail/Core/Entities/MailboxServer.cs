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

namespace ASC.Mail.Core.Entities
{
    public class MailboxServer : IEquatable<MailboxServer>
    {
        ///<example type="int">1234</example>
        public int Id { get; set; }

        ///<example type="int">1234</example>
        public int ProviderId { get; set; }

        ///<example>Type</example>
        public string Type { get; set; }

        ///<example>Hostname</example>
        public string Hostname { get; set; }

        ///<example type="int">1234</example>
        public int Port { get; set; }

        ///<example>SocketType</example>
        public string SocketType { get; set; }

        private string _username;

        ///<example>Username</example>
        public string Username
        {
            get { return _username; }
            set { _username = value ?? ""; }
        }

        private string _auth;

        ///<example>Authentication</example>
        public string Authentication
        {
            get { return _auth; }
            set
            {
                _auth = value ?? "";
            }
        }

        ///<example>true</example>
        public bool IsUserData { get; set; }

        #region Equality

        public bool Equals(MailboxServer other)
        {
            if (other == null) return false;
            return string.Equals(Type, other.Type, StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(Hostname, other.Hostname, StringComparison.InvariantCultureIgnoreCase) &&
                Port == other.Port &&
                string.Equals(SocketType, other.SocketType, StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(Username, other.Username, StringComparison.InvariantCultureIgnoreCase) &&
                string.Equals(Authentication, other.Authentication, StringComparison.InvariantCultureIgnoreCase);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals(obj as MailboxServer);
        }

        public override int GetHashCode()
        {
            return Type.GetHashCode() ^ Hostname.GetHashCode() ^ Port.GetHashCode() ^ SocketType.GetHashCode() ^
                   Username.GetHashCode() ^ Authentication.GetHashCode();
        }

        #endregion
    }
}
