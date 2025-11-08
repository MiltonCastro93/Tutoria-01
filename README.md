<h1 align="center">📘 Tutoria-01</h1>
<p align="center">
  <i>Repositorio en constante evolución — Proyecto orientado a la enseñanza y experimentación técnica en entornos de desarrollo 3D y programación en Unity.</i>
</p>

---

### 🎯 Propósito
Este repositorio tiene como objetivo documentar y compartir diferentes clases y sesiones prácticas que abarcan conceptos esenciales del desarrollo de videojuegos, integración de software 3D y fundamentos de programación aplicada en Unity.  
Cada clase se enfoca en un tema específico y evoluciona con nuevos ejemplos, scripts y recursos complementarios.

---

### 📚 Índice de Clases

<table align="center">
  <tr>
    <th align="center">Clase</th>
    <th align="center">Tema</th>
    <th align="center">Contenido</th>
    <th align="center">Estado</th>
  </tr>

  <tr>
    <td align="center"><b>Clase N°1</b></td>
    <td align="center">Rig, SDK y Delegados</td>
    <td>
      <ul>
        <li>Rig en <b>Blender</b> (jerarquías, controladores, exportación)</li>
        <li>Flujo de trabajo entre <b>Daz3D → Blender → Unity</b></li>
        <li>Diferencias entre <code>delegate</code>, <code>Action</code> y <code>Func</code></li>
      </ul>
    </td>
    <td align="center">✅ Finalizada</td>
  </tr>

  <tr>
    <td align="center"><b>Clase N°2</b></td>
    <td align="center">Eventos y Comunicación en Unity</td>
    <td>
      <ul>
        <li>Uso y diferencias entre <code>Event</code> y <code>UnityEvent</code></li>
        <li>Ventajas del sistema de eventos frente a llamadas directas</li>
        <li>Cómo crear sistemas desacoplados para interacción entre objetos</li>
        <li>Ejemplos prácticos en C# y editor de Unity</li>
      </ul>
    </td>
    <td align="center">🕓 En desarrollo</td>
  </tr>
</table>

---

### 🧩 Detalle de la Clase N°1

#### 🦴 Rig en Blender
- Explicación sobre la estructura de *bones*, jerarquías y controladores.  
- Diferencias entre un rig básico y un rig facial.  
- Preparación del modelo para exportación a motores de juego.

#### 🔗 SDK y Flujo de Trabajo: *Daz3D → Blender → Unity*
- Exportación de modelos desde Daz3D con su SDK correspondiente.  
- Ajustes de materiales y corrección de escalado en Blender.  
- Integración final en Unity manteniendo esqueleto y animaciones.  
- Consejos para evitar errores de rotación o desalineación.

#### ⚙️ Delegados, Action y Func en C#
- Comparativa práctica entre `delegate`, `Action` y `Func`.  
- Aplicaciones en eventos, callbacks y modularidad de sistemas.  
- Ejemplos implementados en scripts de Unity con comentarios explicativos.

---
---

### 🧩 Detalle de la Clase N°2

#### 🔔 UnityEvent vs Event
- **`UnityEvent`** permite vincular funciones desde el *Inspector*, facilitando el trabajo visual sin código.  
- **`Event`** (C# nativo) ofrece más control y encapsulación, ideal para sistemas internos de lógica.  
- Ejemplo práctico: disparo de eventos entre scripts de UI y gameplay (botones, interacción, etc).

#### ⚙️ Conceptos Clave
- Desacoplar dependencias entre componentes.
- Creación de eventos personalizados.
- Cómo suscribirse y desuscribirse correctamente para evitar *memory leaks*.
