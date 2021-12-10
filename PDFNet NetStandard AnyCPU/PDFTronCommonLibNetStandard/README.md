### Considerations for Any CPU implementation

- The PDFTronCommonLibNetStandard libary has x64 and x86 PDFTronCore (.NET Standard 2.0 for AnyCPU) and PDFNet (native lib for x64 and x86)
- The PDFTronAssemblyLoader is used to dynamic load either x64 or x86 reference in runtime by checking the `Environment.Is64BitOperatingSystem` state and using a reflection call `Assembly.LoadFrom()`.
