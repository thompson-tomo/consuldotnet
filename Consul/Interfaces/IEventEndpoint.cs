﻿// -----------------------------------------------------------------------
//  <copyright file="Health.cs" company="PlayFab Inc">
//    Copyright 2015 PlayFab Inc.
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//  </copyright>
// -----------------------------------------------------------------------

using System.Threading;

namespace Consul
{
    public interface IEventEndpoint
    {
        WriteResult<string> Fire(UserEvent ue);
        WriteResult<string> Fire(UserEvent ue, WriteOptions q);
        ulong IDToIndex(string uuid);
        QueryResult<UserEvent[]> List();
        QueryResult<UserEvent[]> List(string name);
        QueryResult<UserEvent[]> List(string name, QueryOptions q);
        QueryResult<UserEvent[]> List(string name, QueryOptions q, CancellationToken ct);
    }
}