# Proyecto1
# Proyecto de Gestión de Solicitudes

Este proyecto es una aplicación de Windows Forms que permite la gestión de solicitudes, el registro de usuarios y la autenticación. Está desarrollado en VB.NET y utiliza una base de datos SQL Server para el almacenamiento de datos.

## Requisitos

- Visual Studio 2019 o superior
https://visualstudio.microsoft.com/es/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false

- .NET Framework 4.7.2 o superior

- SQL Server 2016 o superior

https://go.microsoft.com/fwlink/p/?LinkID=2216017&clcid=0x40A&culture=es-es&country=es

- SQL Server Management Studio

https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16#download-ssms

## Configuración

1. **Base de Datos**:
   - Asegúrate de tener una instancia de SQL Server en funcionamiento.
   - Crea una base de datos llamada `Progra3`.
   - Ejecuta el siguiente script SQL para crear la table. Favor referirse al script de base de datos (dbscript.txt) para la creacion de las bases de datos.


2. **Cadena de Conexión**:
   - Actualiza la cadena de conexión en la clase `Solicitudes` con tu servidor SQL y credenciales adecuadas.

     ```vb
     Private connectionString As String = "Data Source=TU_SERVIDOR;Initial Catalog=Progra3;Integrated Security=True"
     ```

## Estructura del Proyecto

- **Form1**: La ventana principal de la aplicación que gestiona la navegación entre diferentes formularios.
- **login**: El formulario de inicio de sesión.
- **registro**: El formulario para registrar nuevos usuarios.
- **Solicitudes**: El formulario para la gestión de solicitudes, accesible solo por administradores.
- **NuevaSolicitud**: El formulario para que los usuarios creen nuevas solicitudes.
- **MisSolicitudes**: El formulario para que los usuarios vean sus propias solicitudes.

## Funcionalidades

- **Inicio de Sesión**:
  - Los usuarios pueden iniciar sesión con su usuario y contraseña.
  - La contraseña está encriptada para mayor seguridad.
  
- **Registro de Usuario**:
  - Los nuevos usuarios pueden registrarse proporcionando un usuario, una contraseña y una identificación.
  - La aplicación verifica si el usuario o identificación ya existen antes de permitir el registro.

- **Gestión de Solicitudes**:
  - Los administradores pueden ver todas las solicitudes y cambiar su estado (Solicitado, Aprobado, Denegado).
  - Los usuarios pueden crear nuevas solicitudes y consultar el estado de sus propias solicitudes.

## Uso

1. **Inicio de Sesión**:
   - Ejecuta la aplicación.
   - Introduce tus credenciales para iniciar sesión.
   - Si no tienes una cuenta, utiliza el formulario de registro para crear una.

2. **Registro de Usuario**:
   - Completa el formulario de registro con un usuario, una contraseña y una identificación.
   - Verifica que el usuario y la identificación no estén en uso.

3. **Gestión de Solicitudes**:
   - Los administradores pueden acceder al formulario de `Solicitudes` desde el menú principal.
   - Los usuarios pueden crear nuevas solicitudes y ver el estado de sus solicitudes existentes.

## Notas

- Asegúrate de mantener segura la cadena de conexión y no exponerla públicamente.
- La aplicación utiliza encriptación básica para las contraseñas; considera usar métodos más avanzados en producción.
