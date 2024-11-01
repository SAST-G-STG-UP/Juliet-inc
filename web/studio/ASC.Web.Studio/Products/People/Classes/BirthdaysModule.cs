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

using ASC.Web.Core;
using ASC.Web.Core.ModuleManagement;
using ASC.Web.People.Core;
using ASC.Web.People.Resources;


namespace ASC.Web.People
{
    public class BirthdaysModule : Module
    {
        private static readonly object locker = new object();
        private static bool registered;

        public override Guid ID
        {
            get { return WebItemManager.BirthdaysProductID; }
        }

        public override Guid ProjectId
        {
            get { return PeopleProduct.ID; }
        }

        public override string Name
        {
            get { return BirthdaysResource.BirthdaysModuleTitle; }
        }

        public override string Description
        {
            get { return BirthdaysResource.BirthdaysModuleDescription; }
        }

        public override string StartURL
        {
            get { return "~/Products/People/Birthdays.aspx?sysname=/modules/birthdays"; }
        }

        public BirthdaysModule()
        {
            Context = new ModuleContext
            {
                DefaultSortOrder = 51,
                SmallIconFileName = string.Empty,
                IconFileName = string.Empty
            };
        }

        public static void RegisterSendMethod()
        {
            if (!registered)
            {
                lock (locker)
                {
                    if (!registered)
                    {
                        registered = true;
                        BirthdaysNotifyClient.Instance.RegisterSendMethod();
                    }
                }
            }
        }
    }
}