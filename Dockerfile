# 1. Imagen base: runtime de .NET 9
FROM mcr.microsoft.com/dotnet/runtime:9.0 AS runtime

# 2. Directorio de trabajo dentro del contenedor
WORKDIR /app

# 3. Copiar los archivos publicados (el pipeline creará la carpeta publish)
COPY publish/ ./

# 4. Variables de entorno por defecto
ENV DEPLOYMENT_MODE=production
ENV HOST=http://+
ENV PORT=8080

# 5. Exponer el puerto donde escucha el API
EXPOSE 8080

# 6. Comando de entrada: correr la API
ENTRYPOINT ["dotnet", "Smdb.Api.dll"]
