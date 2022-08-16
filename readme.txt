dotnet new webapp --no-https

#install signalR
libman install @aspnet/signalr -p unpkg -d wwwroot/lib/signalr --files dist/browser/signalr.js --files dist/browser/signalr.min.js

dotnet run => Startup.cs
dotnet watch run --project SignalrSketchPad.csproj