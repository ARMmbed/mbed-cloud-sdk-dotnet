// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using MbedCloud.SDK;
// using MbedCloud.SDK.Common;
// using MbedCloud.SDK.Entities;
// using MbedCloud.SDK.Enums;
// using MbedCloudSDK.Exceptions;
// using NUnit.Framework;

// namespace Snippets.src.Foundation
// {
//     public class Entities
//     {
//         [Test]
//         public async Task Quick()
//         {
//             try
//             {
//                 // an example: checking account status
//                 var myAccount = await new Account().Me();
//                 var isActive = myAccount.Status == AccountStatusEnum.ACTIVE;
//                 // end of example

//                 Assert.IsTrue(isActive);
//             }
//             catch (System.Exception)
//             {
//                 throw;
//             }
//         }

//         [Test]
//         public void Listing()
//         {
//             try
//             {
//                 // an example: listing api keys
//                 var allKeys = new ApiKey().List();
//                 var allKeyNames = allKeys.Select(k => k.Name);
//                 // end of example

//                 Assert.GreaterOrEqual(allKeyNames.Count(), 1);
//             }
//             catch (System.Exception)
//             {
//                 throw;
//             }
//         }

//         [Test]
//         public void CustomConfig()
//         {
//             try
//             {
//                 // an example: using multiple api keys
//                 var allUsers = new List<User>();
//                 new List<string> { "ak_1", "ak_2" }.ForEach(k => allUsers.AddRange(new SDK(new Config(k)).Entities.User.List()));
//                 // end of example
//             }
//             catch (CloudApiException e) when (e.ErrorCode == 401)
//             {
//                 // not a valid api key so will fail
//                 return;
//             }
//             catch (System.Exception)
//             {
//                 throw;
//             }
//         }

//         [Test]
//         public void ReallyCustomConfig()
//         {
//             try
//             {
//                 // an example: using custom hosts
//                 var config = new Config(apiKey: "ak_1", host: "https://example");
//                 var allUsers = new SDK(config).Entities.User.List();
//                 // end of example
//             }
//             catch (CloudApiException)
//             {
//                 // not a valid api key so will fail
//                 return;
//             }
//             catch (System.Exception)
//             {
//                 throw;
//             }
//         }
//     }
// }