## Simple mobile toaster

This simple toast message asset for unity. It includes Android and iOS toast message.

Android Framework: https://github.com/nsctnky/AndroidToaster <br>
iOS Framework: https://github.com/nsctnky/iOSToaster <br>

#### Usage
```csharp
    bool isShortDuration = true
    Toast toast = new Toast("Example Toast Message", isShortDuration);
    toast.Show();
```