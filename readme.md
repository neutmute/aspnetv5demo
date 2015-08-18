# Experiments in ASP.NET 5 vNext #

A lean ASP.NET 5 web project that demonstrates:

- MV6 `Tag Helper` from external and internal assemblies
- `NLog` configured via code
- `Common.Logging` bindings
- `TypeScript` residing in `wwwroot` with a `grunt-watch` task keeping it hot
- `Bower` components deployed to and consumed from `wwwroot`

## Build
Building the `aspnetv5demo` project should automatically copy the submodule `SteelCap` binaries to the web project's `bin` folder.