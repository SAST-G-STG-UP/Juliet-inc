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
using System.IO;

namespace ASC.Data.Storage.ZipOperators
{
    public static class ZipWriteOperatorFactory
    {
        public static IDataWriteOperator GetWriteOperator(string storageBasePath, string title, string tempFolder, Guid userId, IGetterWriteOperator getter)
        {
            var writer = getter.GetWriteOperator(storageBasePath, title, userId);

            return writer ?? new ZipWriteOperator(Path.Combine(tempFolder, title));
        }

        public static IDataWriteOperator GetDefaultWriteOperator(string backupFilePath)
        {
            return new ZipWriteOperator(backupFilePath);
        }
    }
}
