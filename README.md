# API Gateway

Este proyecto es el **API Gateway** del sistema de **E-Commerce**.  
Su función principal es actuar como un **punto único de entrada** para todas las APIs internas, gestionando el enrutamiento, la autenticación y el control de acceso.

## Tecnologías utilizadas

- ASP.NET Core Web API
- Ocelot (Gateway Middleware)
- JWT Bearer Authentication
- Cache Manager (para optimizar rutas)
- Middleware personalizado
- Clean Configuration (carga de Ocelot.json)

## Funcionalidades principales

- Redirige las peticiones a las APIs correspondientes:
  - **Authentication API**
  - **Product API**
  - **Order API**
- Maneja la autenticación de usuarios usando **tokens JWT**.
- Permite configurar el comportamiento de enrutamiento mediante el archivo `Ocelot.json`.
- Aplica políticas de **CORS** para permitir accesos desde diferentes orígenes.

## Cómo ejecutar

1. Clonar este repositorio:

