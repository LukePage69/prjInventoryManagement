### What pointer types are in C#. When they are used. Why they require unsafe context? (BillWagner,2025)
A pointer type variable in C# is one that allows direct memory access by storing the memory address of another variable. 
Because pointers are only available in an unsafe environment, the compiler needs the unsafe keyword and the AllowUnsafeBlocks compiler option in order to ensure memory safety. 
Usually, they are employed in situations that call for memory manipulation without array bounds checks, interoperability with unmanaged code, or performance-critical activities. 
C# limits the usage of pointers to explicitly indicated unsafe code blocks because they circumvent the managed memory model and garbage collector tracking, which can result in
security and stability problems if abused.

---

## Referencing
1. BillWagner (2025). Unsafe code, pointers to data, and function pointers. [online] learn.microsoft.com. Available at: <<https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/unsafe-code>>. Last Accessed 08 August 2025.
---
