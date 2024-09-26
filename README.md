# PDF Service Documentation

## Table of Contents
1. [What is PDF Service?](#what-is-pdf-service)
2. [How to Use](#how-to-use)
3. [Input Object](#input-object)
   - [Primary Field](#primary-field)
   - [Collection](#collection)
4. [Support Generate First Page](#support-generate-first-page)
5. [Some CSS Classes Support](#some-css-classes-support)
6. [Optional Callback Function](#optional-callback-function)
7. [Table of Contents Generation](#table-of-contents-generation)

## What is PDF Service?

A PDF service is a specialized endpoint designed to generate PDF documents from a variety of inputs, including HTML templates, CSS stylesheets, and dynamic data payloads. This service automates the creation of high-quality, consistent, and print-ready PDFs by processing these inputs and converting them into a final document that accurately reflects the original design and content.

## How It Works

### 1. Input HTML and CSS

The service utilizes an HTML file as the foundational template, with optional CSS for precise styling and layout control.

### 2. Dynamic Data Integration

It integrates dynamic data through a payload, allowing for the creation of personalized content tailored to specific fields, such as names, dates, or other relevant information.

### 3. PDF Generation

The service processes the HTML, embeds the data, applies the styling, and converts the result into a PDF file that preserves the structure and appearance of the original content.

### 4. PDF Retrieval

The generated PDF can be accessed and downloaded using a unique identifier, ensuring secure and straightforward retrieval.

### 5. Optional Callback Function

For external systems, a callback function can be defined to automatically receive the PDF file once it has been generated, enabling seamless integration with other workflows.

### 6. Table of Contents Generation
If the `IncludeTOC` setting is set to `true`, the service will automatically generate a Table of Contents (TOC) for the document. The TOC is based on the heading elements defined within the HTML template, and the system applies predefined rules to determine which headings should be included and how they should be formatted.

This service is particularly valuable for applications that require on-demand creation of standardized documents, such as invoices, reports, contracts, or certificates, ensuring a professional and uniform appearance across all generated files.

## How to Use

To generate a PDF, follow these steps:

### 1. Prepare the HTML Template [here](/Documents/fullExample.html)

**Create the Template:** Start by creating an HTML file that will serve as your template. Use placeholders in the template for dynamic content, utilizing a merge field syntax like `{$key}`.

**Embed CSS:** Optionally, you can include inline CSS within your HTML to control the styling and layout.

### 2. Optional External CSS File [here](/Documents/fullExample.css)

If you need more extensive styling control, prepare an external CSS file. This file can complement any inline styles in your HTML, giving you more flexibility in design.

### 3. Input Object

Define the input object that includes all the necessary fields for generating the PDF.

- **Primary Field:** The main content field for the template. [here](/Documents/fullExample_primaryFields.json)
- **Collection:** A list of data items that can be iterated over in the template. [here](/Documents/fullExample_collection.json)
- **Support Generate First Page:** Option to generate an automatic first page based on the content.
- **CSS Classes Support:** Define and use CSS classes that the service supports.

### 4. Optional Callback Function

If needed, configure a callback function to receive the PDF file once it has been generated. This enables seamless integration with other systems and workflows.

### 6. Culture
Define the cultural context to ensure proper localization, such as date formats and language.

### 7. IncludeTOC
If your document requires a Table of Contents (TOC), you can enable this feature by setting the `IncludeTOC` option to `true` in your input object. This instructs the PDF service to automatically generate and include a TOC in the final PDF based on the headings present in your HTML template.

### 8. Send a POST Request
Once your HTML, CSS and data are ready, send a POST request to the following URL to generate the PDF: `https://pdfservice.{env}.miljoeportal.dk/api/v1/GeneratePdf`
![full request](/Documents/images/full-request.png)

### 9. Get pdf file by Id
After pdf file is generated, we will get it by Id via: `https://pdfservice.{env}.miljoeportal.dk/api/v1/pdfReport/{Id}`
![alt text](/Documents/images/response.png)

# Input Object
| [Input Object](/Documents/docs/Input.md)|

# Primary Field
| [Primary Field](/Documents/docs/PrimaryFields.md)|

# Collection
 | [Collection](/Documents/docs/Collection.md)|

# Support generate first page
 | [Support generate first page](/Documents/docs/SupportGenerateFirstPage.md)|

# Some Css classes support
 | [Some Css classes support](/Documents/docs/SomeCssClassesSupport.md)|

# Optional callback function
 | [Optional callback function](/Documents/docs/OptionalCallbackFunction.md)|

# Table of Contents Generation
 | [Table of Contents Generation](/Documents/docs/TocGeneration.md)|