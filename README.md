# Proyecto ASP.NET Core MVC

## Descripción

Este proyecto es una solución desarrollada utilizando una plantilla de ASP.NET Core MVC. El desarrollo se realizó con el IDE Visual Studio 2022 Community, escrito en C# y utilizando SQL Server como base de datos.

Profesor: Jose André Arias Brenes

## Tecnologías Utilizadas

- **ASP.NET Core MVC**: Framework para desarrollar aplicaciones web robustas y escalables.
- **C#**: Lenguaje de programación principal utilizado en el desarrollo del proyecto.
- **Visual Studio 2022 Community**: IDE utilizado para la creación, desarrollo y depuración de la solución.
- **SQL Server**: Sistema de gestión de bases de datos utilizado para almacenar y gestionar los datos de la aplicación.

## Requisitos Previos

Antes de clonar y ejecutar este proyecto, asegúrate de tener instalados los siguientes componentes:

- [Visual Studio 2022 Community](https://visualstudio.microsoft.com/vs/community/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)

## Instalación y Configuración

1. **Clonar el Repositorio**

   ```bash
   git clone https://github.com/usuario/repositorio.git
2. **Abrir el Proyecto en Visual Studio 2022 Community**

Abre Visual Studio 2022 y selecciona Open a project or solution. Navega hasta la carpeta donde clonaste el repositorio y abre el archivo de solución .sln.

3. **Configurar la Base de Datos**
   
Asegúrate de tener SQL Server instalado y en ejecución. Configura la cadena de conexión en el archivo appsettings.json en la raíz del proyecto. Debería verse algo similar a esto:
```bash
"ConnectionStrings": {
  "DefaultConnection": "Server=tu_servidor;Database=tu_base_de_datos;User Id=tu_usuario;Password=tu_contraseña;"
}
