# TableComponent
Simple Blazor component that enables you to, by only passing a ``List<T>``, show a table and update the records by double clicking it.<br>
![preview gif](https://github.com/LeoUpperThrower4/TableComponent/blob/main/Media/DbClickableTableComp.gif)
## Usage
 ` <Table T="Class" ListModel="List Instance" OnCanUpdateAsync="Delegate"/> ` <br />
`T`: The class type <br>
`ListModel`: The `List<Class>` instance
`OnCanUpdateAsync`: Delegate that will be triggered when the user hits tab after editing a field in the table. (Basically, after Javascript function `onfocusout` gets triggered). The updated Class Instance is sent by the Delegate.<br>
You can pass string that will override the default table's CSS.
## Example:
You can find an example project in the **Example** folder
