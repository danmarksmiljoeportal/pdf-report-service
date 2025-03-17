# Visibility Control with `hidden-paragraph` and `validate-rule` Classes

This implementation involves two classes that determine whether a section should be displayed based on the content inside a child element.

## HTML Structure

```html
<h1>Example for hidden paragraph</h1>
<div class="hidden-paragraph">
  <span>My name is: </span>
  <span class="validate-rule">{{ name }}</span>
</div>
<div class="hidden-paragraph">
  <span>This value will not be shown if hidden_value is null: </span>
  <span class="validate-rule">{{hidden_value}}</span>
</div>
```

## Example

**HTML Template:** [here](../supportCssClasses.html)

**Payload:** To control the visibility of the hidden-paragraph section

- Original json

```json
{ "name": "John Doe", "hidden_value": "Secret Data" }
```

This sample shows when both name and hidden_value have values:
![alt text](../images/hiden-paragraph.png)

but when you unset hidden_value or the data is set null

- To hide the section:

```json
{ "name": "John Doe" }
```

the section hidden_value will hide

## Explanation

- `hidden-paragraph`: This parent class controls the visibility of the entire section. It determines whether the section should be shown or hidden based on the content inside its child elements.

- `validate-rule`: This child class contains dynamic content, such as `{$Name}`. If this content is empty or not present, the entire section (i.e., the element with the `hidden-paragraph` class) should be hidden from view.
