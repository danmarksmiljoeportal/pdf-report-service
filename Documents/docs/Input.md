# PDF Service Input Fields

This section details the input fields required for the PDF service, which generates PDF documents from HTML templates and associated data.

## Input Fields

| **Name**          | **Type** | **Description**                                                                                                      | **Required** | **Default** |
|-------------------|----------|----------------------------------------------------------------------------------------------------------------------|--------------|-------------|
| `PrimaryFields`   | String   | Contains a list of simple text-based merge fields for direct value substitutions within the template.                | No           |             |
| `Collection`      | String   | Organizes complex merge fields into nested objects, facilitating structured data and hierarchical relationships within the template. | No           |             |
| `HTML`            | File     | Represents the HTML template file, which can be either a fully styled document with embedded CSS or plain HTML content for further customization. | Yes          |             |
| `CSS`             | File     | Provides an optional external CSS file to style the HTML content.                                                    | No           |             |
| `Culture`         | String   | Specifies the cultural or regional settings used to format data types such as numbers, dates, and times. Currently supported values are `"da-DK"` and `"en-US"`. | No           | `en-US`     |
| `AutoGenFrontPage`| Boolean  | Specifies whether to include the document's first page in the generated output.                                       | No           | `false`     |
| `Headline`        | String   | Defines the main headline to be displayed in the document.                                                           | Conditional  |             |
| `SystemName`      | String   | Indicates the name of the system or application generating the document.                                              | Conditional  |             |
| `Logo`            | String   | Can be a URL or base64-encoded image to be used as the logo in the document.                                          | Conditional  |             |
| `CallbackUrl`     | String   | A string containing a URL that will be called after the document generation process is complete.                      | No           |             |
| `IncludeTOC`     | Boolean   | Specifies whether to include a Table of Contents (TOC) in the generated PDF. When set to true, the TOC is automatically generated based on the headings in the HTML template.                      | No           |     `false`         |

## Notes

- The fields `Headline`, `SystemName`, and `Logo` are required only if the first page is included (i.e., when `AutoGenFrontPage` is set to `true`).
- The `CSS` file is optional but can be included to provide additional styling beyond what is embedded in the HTML.
