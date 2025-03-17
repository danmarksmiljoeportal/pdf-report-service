# PDF Service Input Fields

This section details the input fields required for the PDF service, which generates PDF documents from HTML templates and associated data.

## Input Fields

### **Updated Table**

| **Name**           | **Type** | **Description**                                                                                                                                                      | **Required** | **Default** |
| ------------------ | -------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------ | ----------- |
| `TemplateData`     | String   | Nested JSON object to replace data for the template.                                                                                                                 | No           |             |
| `TemplateDataFile` | File     | A file containing the `TemplateData`, allowing the use of an external file instead of inline JSON.                                                                   | No           |             |
| `HTML`             | File     | Represents the HTML template file, uploaded via form data input.                                                                                                     | No           |             |
| `Css`              | File     | Provides an optional external CSS file, uploaded via form data input.                                                                                                | No           |             |
| `HtmlTemplate`     | String   | A reference to an HTML template stored in the service for use.                                                                                                       | No           |             |
| `CssTemplate`      | String   | A reference to a CSS template stored in the service for use.                                                                                                         | No           |             |
| `Culture`          | String   | Specifies the cultural or regional settings used to format data types such as numbers, dates, and times. Supported values: `"da-DK"`, `"en-US"`.                     | No           | `en-US`     |
| `FrontPage`        | Object   | A nested object containing properties related to the document’s first page.                                                                                          | No           | `{}`        |
| `CallbackUrl`      | String   | A URL that will be called after the document generation process is complete.                                                                                         | No           |             |
| `IncludeTOC`       | Boolean  | Specifies whether to include a Table of Contents (TOC) in the generated PDF. When `true`, the TOC is automatically generated based on headings in the HTML template. | No           | `false`     |

### **FrontPage Nested Structure**

| **Name**           | **Type** | **Description**                                                                 | **Required** | **Default** |
| ------------------ | -------- | ------------------------------------------------------------------------------- | ------------ | ----------- |
| `AutoGenFrontPage` | Boolean  | Specifies whether to include the document's first page in the generated output. | No           | `false`     |
| `Headline`         | String   | Defines the main headline to be displayed in the document.                      | Conditional  |             |
| `SystemName`       | String   | Indicates the name of the system or application generating the document.        | Conditional  |             |
| `Logo`             | String   | Can be a URL or base64-encoded image to be used as the logo in the document.    | Conditional  |             |

## Notes

- Either `HTML` or `HtmlTemplate` must be provided. If `HTML` is uploaded as a file, `HtmlTemplate` should not be specified, and vice versa. The system will use the provided template source to generate the document.
- The fields `Headline`, `SystemName`, and `Logo` are required only if the first page is included (i.e., when `AutoGenFrontPage` is set to `true`).
- The `CSS` file is optional but can be included to provide additional styling beyond what is embedded in the HTML.

## Response Structure

### Return Report ID for API-Based Download

| **Field**  | **Type** | **Description**                                                                                             |
| ---------- | -------- | ----------------------------------------------------------------------------------------------------------- |
| `reportId` | String   | A unique identifier for the generated report, which can be used in an API request to download the PDF file. |

### Example Response:

```json
{
  "reportId": "12345-abcdef-67890"
}
```

### API Endpoint to Download Report by ID

| **Method** | **Endpoint**              |
| ---------- | ------------------------- |
| `GET`      | `/api/get-pdf/{reportId}` |

#### Response:

- Returns the PDF file associated with the given `reportId`.

#### Return URL to Download PDF File

| **Field** | **Type** | **Description**                                    |
| --------- | -------- | -------------------------------------------------- |
| `Url`     | String   | The direct URL to download the generated PDF file. |

#### Example Response:

```json
{
  "Url": "https://example.com/downloads/report.pdf"
}
```
