# Optional Callback Function for PDF Service

The optional callback function allows you to specify a URL to which the service will post information once the PDF generation is complete. 

## How It Works

### Purpose

After the PDF file has been successfully generated, the service can notify an external system by sending a POST request to a specified callback URL.

### Callback URL

This URL is provided when setting up the callback. It should be an endpoint that can handle the incoming POST request.

### Data Posted

The service will send a POST request to your callback URL with the following information:

- **fileName**: The name of the generated PDF file.
- **url**: The URL where the PDF can be downloaded.
- **errorMessage**: Any error messages that occurred during the PDF generation process (if applicable).

### Example Workflow

1. **Configure Callback URL**: When initiating the PDF generation request, include the callback URL where the service should send the result.

2. **Generate PDF**: The service processes the HTML, CSS, and data, and generates the PDF.

3. **Callback Notification**: Upon completion, the service sends a POST request to your specified callback URL with the details of the generated PDF or any error encountered.

### Example POST Request to Callback URL

```json
{
  "fileName": "example.pdf",
  "URL": "https://pdfservice.{env}.miljoeportal.dk/api/v1/pdfReport/{Id}",
  "errorMessage": "" // Empty if no errors occurred
}
```

## How to create an endpoint

### Define a model for the incoming data
Create a model class to represent the data structure you expect to receive in the POST request:
For example:

```
public class ReportResult
{
    public string Name { get; set; }
    public string Url { get; set; }
    public string ErrorMessage { get; set; }
}
```

### Create the API Endpoint to Receive the Data
Implement an API endpoint in your application to handle the incoming POST request. This endpoint should be designed to accept the ReportResult model you defined:

```
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ReportController : ControllerBase
{
    [HttpPost]
    [Route("receive-report-result")]
    public IActionResult ReceiveReportResult([FromBody] ReportResult result)
    {
        if (result == null)
        { 
            return BadRequest("Invalid data.");
        }

        // Implement your logic to handle the received data 

        // Return the received data or an appropriate response
        return Ok(result);
    }
}

```

### Expected Response
When the server processes the request, it should respond with the updated ReportResult data or a relevant status message. For example:

```
{
  "Name": "Report-aae85db1-d9e9-40c6-b212-f185f87199b6.pdf",
  "Url": "https://b1113udvfilesto.blob.core.windows.net/pdf-files/Report-aae85db1-d9e9-40c6-b212-f185f87199b6.pdf?sv=2018-03-28&sr=b&sig=NJuDLFTr5g%2BTPr8Xya5sMbwGhHi%2BsVZEI1Vkcs4agxs%3D&se=2024-09-04T02%3A50%3A48Z&sp=r",
  "Message": ""
}
```