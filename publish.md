## 1. Generate new documentation with Claude

## 2. Generate new API

### a. Remove all markdown files in docs/api

### b. Run: docfx docfx.json --serve

## 3. Build

### a. Increment project version

### b. Set build mode to release

### c. Run: dotnet pack

### d. Merge development with main

## 4. Push to NuGet

### Grab the [PACKAGE] path: ClockworkEngine/bin/Release/ClockworkEngine.X.Y.Z.nupkg

### b. Run: dotnet nuget push [PACKAGE] --api-key [APIKEY] --source https://api.nuget.org/v3/index.json

### c. Check: https://packages.nuget.org/packages/ClockworkEngine

## 5. Update examples

### a. Ensure clockwork-examples `UseLocalEngine` variable is set to false

### &#x09;b. Push clockwork-examples/development to main

## 6. Update template

### &#x09;a. Make sure API is up to date

### &#x09;b. Export template

### &#x09;c. Upload template to GitHub Releases

