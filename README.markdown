# ServiceStack.Logging.Serilog

Provides Serilog logging integration for other ServiceStack projects.

### Usage

```csharp
var logger = new LoggerConfiguration()
    .WriteTo.Console()
    .MinimumLevel.Debug()
    .CreateLogger();

LogManager.LogFactory = new SerilogFactory(logger);
```