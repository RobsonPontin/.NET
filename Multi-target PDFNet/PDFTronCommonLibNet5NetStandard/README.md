### Considerations for Any CPU implementation

- A reference to each .NET version is defined in the *csproj* by checking the `$(TargetFramework)`
- The custom library references the .NET versions (Standard, Core, 5) in the PDFNetC64 package, since it does not matter for Any CPU
- The native library PDFNetC.dll needs to be selected for either x64 or x86 platform
- Both native libraries are committed and located at `win-x64` and `win-x86` folders
- The multi-target custom libary is using `System.Environment.Is64BitOperatingSystem` to check whether the Operating System is x64, so the proper PDFNetC.dll libarary will copied using `CopyToOutputDirectory`
