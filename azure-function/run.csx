#r "Newtonsoft.Json"

using System.Net;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;

public static async Task<IActionResult> Run(HttpRequest req, ILogger log)
{
    log.LogInformation("C# HTTP trigger function processed a request.");

    var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
    log.LogInformation(requestBody);

    dynamic data = JsonConvert.DeserializeObject(requestBody);

    var resultValues = new List<dynamic>();

    foreach (var item in data.values)
    {
        if (item == null || item.recordId == null) continue;

        string itemText = item.data?.text;
        var textLength = itemText?.Length ?? 0;

        resultValues.Add(
            new 
            {
                recordId = item.recordId,
                data = new 
                {
                    textLength
                }            
            }
        );
    }

    var result = new { values = resultValues };

    log.LogInformation("Will return results:");
    log.LogInformation(JsonConvert.SerializeObject(result));

    return new OkObjectResult(result);
}
