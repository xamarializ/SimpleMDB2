# Imagen base para ejecutar aplicaciones .NET
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app

# Copiar los archivos publicados por el pipeline
COPY publish/ ./

# Variables de entorno necesarias para HttpListener
ENV ASPNETCORE_URLS=http://+:8080
ENV PORT=8080
ENV WEBSITES_PORT=8080
ENV HOST=http://+

# Exponer puerto
EXPOSE 8080

# Ejecutar la API
ENTRYPOINT ["dotnet", "Smdb.Api.dll"]

