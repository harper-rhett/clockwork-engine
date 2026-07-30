1. ##### Generate new documentation with Claude

##### 2\. Generate new API

###### &#x09;a. Remove all markdown files in docs/api

###### &#x09;b. Run: docfx docfx.json --serve

##### 3\. Build

###### &#x09;a. Increment project version

###### &#x09;b. Set build mode to release

###### &#x09;c. Run: dotnet pack

##### 4\. Push to NuGet

###### &#x09;a. Grab the \[PACKAGE] path: ClockworkEngine/bin/Release/ClockworkEngine.X.Y.Z.nupkg

###### &#x09;b. Run: dotnet nuget push \[PACKAGE] --api-key \[APIKEY] --source https://api.nuget.org/v3/index.json

###### &#x09;c. Check: https://packages.nuget.org/packages/ClockworkEngine

#### 5\. Update examples

###### &#x09;a. Ensure clockwork-examples `UseLocalEngine` variable is set to false

###### &#x09;b. Push clockwork-examples/development to main

#### 6\. Update template

###### &#x09;a. Make sure API is up to date

###### &#x09;b. Export template

###### &#x09;c. Upload template to GitHub Releases

