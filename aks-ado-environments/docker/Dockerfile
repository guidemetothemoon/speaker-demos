FROM mcr.microsoft.com/dotnet/nightly/aspnet:6.0-jammy-chiseled
WORKDIR /App
COPY CatEncyclopedia/src App/
ENV PORT 8080
EXPOSE 8080
ENTRYPOINT ["dotnet", "CatEncyclopedia.dll"]