using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ReportCallbackController : ControllerBase
{
    /// <summary>
    /// Receives a report result and processes it.
    /// </summary>
    /// <param name="result">The report result data from the request body.</param>
    /// <returns>An IActionResult indicating the outcome of the operation.</returns>
    [HttpPost]
    public IActionResult ReceiveReportResult([FromBody] ReportResult result)
    {
        // Validate the incoming data
        if (result == null)
        {
            return BadRequest("Invalid data.");
        }

        // Implement your logic to handle the received data
        // For example, you might want to save it to a database or process it further

        // Return a successful response with the received data
        return Ok(new
        {
            Name = result.Name,
            Url = result.Url,
            Message = result.Message ?? string.Empty
        });
    }
}
