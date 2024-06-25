<!-- default file list -->
*Files to look at*:

* [Contact.cs](./CS/DXSample.Module/Contact.cs) (VB: [Contact.vb](./VB/DXSample.Module/Contact.vb))
* **[FilterByUserController.cs](./CS/DXSample.Module/FilterByUserController.cs) (VB: [FilterByUserController.vb](./VB/DXSample.Module/FilterByUserController.vb))**
* [IOwnedObject.cs](./CS/DXSample.Module/IOwnedObject.cs) (VB: [IOwnedObject.vb](./VB/DXSample.Module/IOwnedObject.vb))
* [Updater.cs](./CS/DXSample.Module/Updater.cs) (VB: [Updater.vb](./VB/DXSample.Module/Updater.vb))
<!-- default file list end -->
# OBSOLETE - How to filter persistent objects in ListView, according to the user owning them (Simple Security)


<p><strong>=======================================</strong></p><p><strong>This example is related to the old security system. To learn how to implement this functionality in the new security system, refer to the</strong> <a href="https://www.devexpress.com/Support/Center/p/Q430153">How to filter records by the current user (the object owner feature)</a><strong> ticket.</strong><strong><br />
=======================================</strong></p><p>In ListView, sometimes it's necessary to show only those persistent objects, which were created by a logged-in user. This example demonstrates how you can accomplish this task. The IOwnedObject interface will be added, and the Contact business class will implement it. The FilterByUserController ViewController will release the ListView filtering.</p>

<br/>


