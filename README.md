# API de Información de Pokémon (.NET 9)

Este repositorio contiene una API desarrollada en .NET 9 que permite obtener información detallada de Pokémon por nombre. La API sigue la arquitectura hexagonal para una clara separación de responsabilidades y mantenibilidad.

## Características Principales

* **Arquitectura Hexagonal:** Diseño limpio y modular para facilitar el desarrollo y las pruebas.
* **.NET 9:** Construida con la última versión de .NET para rendimiento y características modernas.
* **Entity Framework Core:** Utilizado para la persistencia de datos, permitiendo una interacción eficiente con la base de datos.
* **Dapper:** Implementado para consultas de alto rendimiento y obtención de datos optimizada.
* **Contenedorización con Docker:** La API y la base de datos SQL Server están empaquetadas en contenedores Docker para una fácil implementación y portabilidad.
* **Pruebas Unitarias con xUnit y Playwright:** Se incluyen pruebas unitarias exhaustivas utilizando xUnit y Playwright para asegurar la calidad y estabilidad del código.

## Tecnologías Utilizadas

* .NET 9
* Entity Framework Core
* Dapper
* Docker
* Docker Compose
* xUnit
* Playwright
* SQL Server

## Requisitos Previos

Asegúrate de tener instaladas las siguientes herramientas:

* Docker
* Docker Compose
* .NET SDK 9 (para ejecutar las pruebas)

## Configuración y Ejecución

1.  **Clonar el Repositorio:**

    ```bash
    git clone https://github.com/juanmoris/PokemonApi.git
    ```

2.  **Levantar los Contenedores con Docker Compose:**

    ```bash
    docker-compose up
    ```

    Este comando iniciará la API y la base de datos SQL Server en contenedores Docker.

3.  **Ejecutar las Pruebas Unitarias:**

    ```bash
    dotnet test
    ```

    Este comando ejecutará las pruebas unitarias utilizando xUnit y Playwright. Asegúrate de que los contenedores estén en ejecución antes de ejecutar las pruebas.

## Endpoints de la API

* `GET /pokemon/{nombre}`: Obtiene la información de un Pokémon por su nombre.

## Contribución

¡Las contribuciones son bienvenidas! Si encuentras algún problema o tienes sugerencias de mejora, por favor, abre un issue o envía un pull request.

## Contacto

moris_juan@hotmail.com
