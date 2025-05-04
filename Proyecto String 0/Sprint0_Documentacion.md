# Sprint 0 - Documentación

## Nombre del Proyecto
AutoLote360 - Plataforma Web de Gestión y Venta de Vehículos

## Idea Principal del Proyecto
Desarrollar una aplicación web que permita a los autolotes gestionar su inventario de vehículos, facilitar la venta en línea, publicar automóviles con fotos y detalles, y permitir a los usuarios buscar, comparar y contactar a los vendedores de forma ágil y moderna.

## Enunciado del Proyecto
AutoLote360 es una plataforma web dirigida a propietarios de autolotes y compradores de vehículos. Permitirá a los autolotes administrar su inventario en tiempo real, publicar vehículos con imágenes, descripciones, precios y estados, mientras que los compradores podrán buscar y filtrar autos según sus preferencias, comparar opciones y contactar al vendedor directamente desde la web. Esta solución busca digitalizar la experiencia de compra-venta de vehículos, reduciendo la dependencia de medios físicos o redes sociales poco organizadas.

## Objetivo General
- Desarrollar una plataforma web moderna que automatice la gestión de vehículos para autolotes y facilite la venta y búsqueda de autos para compradores.

## Objetivos Específicos
- Permitir a los administradores de autolotes registrar y gestionar el inventario de vehículos.
- Permitir a los usuarios buscar vehículos por marca, modelo, año, precio y características.
- Habilitar la publicación de vehículos con múltiples imágenes y detalles relevantes.
- Facilitar la comunicación entre compradores y vendedores mediante formularios de contacto o enlaces directos.
- Garantizar una experiencia de usuario rápida, intuitiva y segura, usando tecnologías modernas como ABP Framework y Angular.

## Alcance del Proyecto

### Incluye:
- Gestión de vehículos (crear, editar, eliminar).
- Visualización pública del catálogo de vehículos.
- Filtros de búsqueda y vista detallada de cada auto.
- Registro de autolotes (como administradores del sistema).
- Registro de usuarios compradores (opcional).
- Panel administrativo para gestión del inventario.
- Contacto con el vendedor desde la ficha del vehículo.

### No incluye:
- Geolocalización avanzada o mapas.
- Módulos de mantenimiento, seguros o trámites vehiculares.
- App móvil nativa (solo versión web responsive).

## Investigación Tecnológica

### ABP Framework
ABP (AspNet Boilerplate) Framework es una infraestructura moderna basada en ASP.NET Core que permite construir aplicaciones modulares, reutilizables y mantenibles. Facilita el desarrollo con características integradas como multitenencia, autenticación, autorización, logging, auditoría y una estructura limpia basada en DDD (Domain-Driven Design). En este proyecto se utilizará para construir el backend siguiendo la arquitectura por capas.

### ASP.NET 9 y arquitectura por capas
ASP.NET 9 es la versión más reciente de la plataforma web de Microsoft. Permite crear APIs REST robustas, escalables y seguras. Se utilizará una arquitectura por capas, separando las responsabilidades en:
- **Domain**: Lógica de negocio y entidades.
- **Application**: Casos de uso y reglas de aplicación.
- **Infrastructure**: Acceso a datos y servicios externos.
- **API**: Puntos de entrada (endpoints) y controladores.

Esta separación mejora el mantenimiento y escalabilidad del sistema.

### Angular
Angular es un framework de frontend moderno basado en TypeScript, ideal para construir interfaces web dinámicas y responsivas. Se usará para implementar el panel de administración del autolote y la interfaz pública del catálogo de vehículos. Angular permite trabajar con componentes reutilizables, enrutamiento, formularios reactivos y servicios HTTP para conectarse al backend.

## Primer Backlog (Historias de Usuario)
- Como **administrador del autolote**, quiero **agregar vehículos al inventario**, para **tener mi catálogo disponible en línea**.
- Como **usuario comprador**, quiero **buscar vehículos por marca y modelo**, para **encontrar rápidamente lo que necesito**.
- Como **usuario comprador**, quiero **ver imágenes y detalles de cada vehículo**, para **evaluar antes de contactar al vendedor**.
- Como **administrador**, quiero **editar o eliminar vehículos del sistema**, para **mantener mi inventario actualizado**.
- Como **usuario comprador**, quiero **contactar al autolote desde la ficha del vehículo**, para **solicitar más información o agendar una visita**.
- Como **administrador**, quiero **ver una lista de todos mis vehículos con filtros**, para **administrarlos fácilmente desde el panel**.
