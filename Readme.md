# OBSOLETE - How to filter persistent objects in ListView, according to the user owning them (Simple Security)


<p><strong>=======================================</strong></p><p><strong>This example is related to the old security system. To learn how to implement this functionality in the new security system, refer to the</strong> <a href="https://www.devexpress.com/Support/Center/p/Q430153">How to filter records by the current user (the object owner feature)</a><strong> ticket.</strong><strong><br />
=======================================</strong></p><p>In ListView, sometimes it's necessary to show only those persistent objects, which were created by a logged-in user. This example demonstrates how you can accomplish this task. The IOwnedObject interface will be added, and the Contact business class will implement it. The FilterByUserController ViewController will release the ListView filtering.</p>

<br/>


