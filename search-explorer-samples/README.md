# Sample queries that you can use in the Search explorer for the demo index in the course

![enter image description here](/search-explorer-samples/readme-search-explorer-screenshot.png)

<table>
  <tr>
  <th>Query</th>
  <th>Description</th>
  </tr>
  <tr>
    <td>*</td>
    <td>Get all documents.</td>
  </tr>
  <tr>
    <td>rock</td>
    <td>Get documents where <b>rock</b> is in one or more of the fields that are marked as <b>searchable</b>.</td>
  </tr>
  <tr>
    <td>rock&$count=true</td>
    <td>Get documents where <b>rock</b> is in one or more of the fields that are marked as <b>searchable</b>, </br> and include the number of matching documents in the result.</td>
  </tr>
  <tr>
    <td>&$count=true&search=rock</td>
    <td>Get documents where <b>rock</b> is in one or more of the fields that are marked as <b>searchable</b>, </br> and include the number of matching documents in the result.</td>
  </tr>
  <tr>
    <td>&$count=true&search=rock guitarist</td>
    <td>Get documents where <b>rock</b> and/or <b>guitarist</b> is in one or more of the fields that are marked as <b>searchable</b>, </br> and include the number of matching documents in the result.</td>
  </tr>
  <tr>
    <td>&$count=true&search="rock guitarist"</td>
    <td>Get documents where <b>rock guitarist</b> is in one or more of the fields that are marked as <b>searchable</b>, </br> and include the number of matching documents in the result.</td>
  </tr>
  <tr>
    <td>&$count=true&search=rock&searchFields=keyphrases</td>
    <td>Get documents where <b>rock</b> is in the <b>keyphrases</b> field, </br> and include the number of matching documents in the result.</td>
  </tr>
  <tr>
    <td>&$count=true&search=rock&$select=content,locations</td>
    <td>Get documents where <b>rock</b> is in one or more of the fields that are marked as <b>searchable</b>, </br> and only return the <b>content</b> and <b>locations</b> fields, </br> and include the number of matching documents in the result.</td>
  </tr>
  <tr>
    <td>&$count=true&search=rock&facet=locations</td>
    <td>Get documents where <b>rock</b> is in one or more of the fields that are marked as <b>searchable</b>, </br> and get the hit count per location (<b>locations</b> is a field that is marked as <b>facetable</b>), </br> and include the number of matching documents in the result.</td>
  </tr>
  <tr>
    <td>&$count=true&search=jazz&$skip=5&$top=2&$select=content</td>
    <td>Get documents where <b>jazz</b> is in one or more of the fields that are marked as <b>searchable</b>, </br> and only return the <b>content</b> field, </br> and only return the top 2 documents after skipping 5, </br> and include the number of matching documents in the result.</td>
  </tr>
  <tr>
    <td>&$count=true&search=jazz&$orderby=metadata_storage_size desc</td>
    <td>Get documents where <b>jazz</b> is in one or more of the fields that are marked as <b>searchable</b>, </br> and sort the results in descending order by <b>metadata_storage_size</b> (which is a field marked as <b>sortable</b>), </br> and include the number of matching documents in the result.</td>
  </tr>
  <tr>
    <td>&$count=true&$filter=locations/any(g: search.in(g, 'London, Chicago'))&$select=content,locations</td>
    <td>Get documents where the <b>locations</b> field contains <b>Londen</b> and/or <b>Chicago</b>, </br> and only return the <b>content</b> and <b>locations</b> fiels, </br> and include the number of matching documents in the result.</td>
  </tr>
  <tr>
    <td>&$count=true&queryType=full&search=keyphrases:producer NOT Beatles&$select=content,keyphrases</td>
    <td>Get documents where the <b>keyphrases</b> field contains <b>producer</b> but not <b>Beatles</b>, </br> and only return the <b>content</b> and <b>keyphrases</b> fiels, </br> and include the number of matching documents in the result.</td>
  </tr>
</table>
