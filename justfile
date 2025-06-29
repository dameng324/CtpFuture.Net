#!/usr/bin/env just --justfile

build:
    dotnet build
  
clean: 
    dotnet clean
    
publish version apikey: build
    dotnet pack -c Release -o out -p:Version={version}
    dotnet nuget push out/*.nupkg -s "https://api.nuget.org/v3/index.json" --api-key {apikey}
    