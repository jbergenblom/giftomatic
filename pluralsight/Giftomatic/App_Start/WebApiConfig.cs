﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace Giftomatic
{
  public static class WebApiConfig
  {
    public static void Register(HttpConfiguration config)
    {
      var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
      jsonFormatter.SerializerSettings.ContractResolver =
        new CamelCasePropertyNamesContractResolver();

      //config.Routes.MapHttpRoute(
      //    name: "UserInputRoute",
      //    routeTemplate: "api/v1/topics/{topicid}/replies/{id}",
      //    defaults: new { controller = "replies", id = RouteParameter.Optional }
      //);

      //config.Routes.MapHttpRoute(
      //    name: "DefaultApi",
      //    routeTemplate: "api/v1/userfeatures/{id}",
      //    defaults: new { controller = "userfeatures", id = RouteParameter.Optional }
      //);

      config.Routes.MapHttpRoute(
          name: "DefaultApi",
          routeTemplate: "api/v1/predictionData/{modelNr}",
          defaults: new { controller = "predictionData", id = RouteParameter.Optional }
      );



      // Uncomment the following line of code to enable query support for actions with an IQueryable or IQueryable<T> return type.
      // To avoid processing unexpected or malicious queries, use the validation settings on QueryableAttribute to validate incoming queries.
      // For more information, visit http://go.microsoft.com/fwlink/?LinkId=279712.
      //config.EnableQuerySupport();
    }
  }
}