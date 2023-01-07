## Simple mobile toaster

This simple toast message asset for unity. It includes Android and iOS toast message.

Android Framework: https://github.com/nsctnky/AndroidToaster
iOS Framework: https://github.com/nsctnky/iOSToaster

#### Usage
```csharp
    bool isShortMessage = true
    Toast toast = new Toast("Example Toast Message", isShortMessage);
    toast.Show();
```