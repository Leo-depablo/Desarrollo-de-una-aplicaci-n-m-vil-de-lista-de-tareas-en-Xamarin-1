# TareasApp (App2)

Una aplicación móvil sencilla creada con Xamarin.Forms para gestionar tareas, permitiendo agregar, editar y eliminar tareas utilizando una base de datos local SQLite.

## Estructura del proyecto
App2/
├── Models/ # Contiene el modelo de datos (Tarea.cs)
├── Services/ # Manejo de la base de datos (DatabaseService.cs)
├── Views/ # Páginas de interfaz (MainPage.xaml, TareaPage.xaml)
├── ViewModels/ # (opcional) Para lógica MVVM
├── App.xaml # Recursos globales
├── App.xaml.cs # Configuración de la app y base de datos
├── AppShell.xaml # Navegación con Shell (si se usa)
└── AppShell.xaml.cs


## Dependencias

- sqlite-net-pcl

Debe instalarse en los siguientes proyectos:
- App2 (proyecto compartido)
- App2.Android
- App2.iOS (si aplica)

## Cómo ejecutar

1. Clona el repositorio o abre la solución en Visual Studio.
2. Verifica que el proyecto App2.Android esté marcado como proyecto de inicio.
3. Ejecuta en un emulador o dispositivo físico presionando F5.
4. Puedes:
   - Ver la lista de tareas
   - Agregar nuevas tareas
   - Editar o eliminar tareas existentes

## Tecnologías usadas

- Xamarin.Forms
- SQLite
- C#
- MVVM (estructura sugerida)

## Licencia

Este proyecto es de uso libre para fines educativos.
