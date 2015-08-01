# Experiments in ASP.NET v5 (vNext) #

A lean web project that demonstrates:

- TagHelpers from external and internal assemblies
- NLog configured via code (haven't got nlog.config conventional location working yet)
- Common.Logging

## Build
Having problems with project reference, need to have check out folder as
`C:\CodeOther\aspnetv5demo` due to nuget not restoring from relative paths

so build steelcap: 

* `$lib\steelcap\dnu restore `
* `$lib\steelcap\dnu build   `
* `$lib\steelcap\dnu pack    `

then compile and run `aspnetv5demo`