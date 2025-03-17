# Template Field Documentation

## SimpleFields

The `SimpleFields` section is designed to store simple, text-based merge fields, facilitating the dynamic insertion of content into templates. This section supports scenarios where basic textual data needs to be replaced within a given template, enabling personalization or content adaptation based on input data.

### Purpose

Stores the basic variable data that can be merged into a template.

### Example

**HTML Template:**

```html
<p>My name is {{ name }}</p>
<p>This is price: {{ price }}</p>
<p>Date is: {{ date }}</p>
<img src="{{ image }}" />
```

## Payload for SimpleFields:

```
{
  "name": "John Doe",
  "price": 199.99,
  "date": "2025-03-17",
  "image": "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b6/Image_created_with_a_mobile_phone.png/800px-Image_created_with_a_mobile_phone.png"
}
```

### Result:

![alt text](/Documents/images/simple-fields-response.png)

In this example, the HTML template includes placeholders `{{name}`, `{{price}}` and `{{$date}}` that will be dynamically replaced with the corresponding values from the payload.
