## Response Structure

### Return Report ID for API-Based Download

| **Field**  | **Type** | **Description**                                                                                             |
| ---------- | -------- | ----------------------------------------------------------------------------------------------------------- |
| `reportId` | GUID     | A unique identifier for the generated report, which can be used in an API request to download the PDF file. |

### Example Response:

```json
{
  "reportId": "3fb91a05-1d41-432b-9781-d6e4272f869b"
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
