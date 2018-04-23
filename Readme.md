# How to copy a chart to the clipboard


<p>This example illustrates how to export a chart to the system clipboard. To accomplish this task, it is first required to export a chart as an image to the memory stream, and then put this memory stream to the clipboard via the static Clipboard.SetImage method.</p><p>However, note, that this approach is applicable to all image formats (e.g. PNG in this example) except for metafiles. If you want to copy a chart to the clipboard as EMF, please use the workaround suggested by Microsoft at <a href="http://support.microsoft.com/?id=323530">http://support.microsoft.com/?id=323530</a>.</p>

<br/>


