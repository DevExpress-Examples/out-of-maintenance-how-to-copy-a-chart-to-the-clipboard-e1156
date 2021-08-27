<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128572973/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1156)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to copy a chart to the clipboard


<p>This example illustrates how to export a chart to the system clipboard. To accomplish this task, it is first required to export a chart as an image to the memory stream, and then put this memory stream to the clipboard via the static Clipboard.SetImage method.</p><p>However, note, that this approach is applicable to all image formats (e.g. PNG in this example) except for metafiles. If you want to copy a chart to the clipboard as EMF, please use the workaround suggested by Microsoft at <a href="http://support.microsoft.com/?id=323530">http://support.microsoft.com/?id=323530</a>.</p>

<br/>


