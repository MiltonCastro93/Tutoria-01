<h1 align="center">🎓 Tutoria-01</h1>
<p align="center">
  Proyecto educativo en constante evolución, donde se documentan clases técnicas sobre <b>Unity</b>, <b>Blender</b> y <b>programación en C#</b>.
  <br>
  Cada clase aborda distintos conceptos teóricos y prácticos aplicados al desarrollo de videojuegos.
</p>

---

<h3 align="center">📘 Clase N°1 — Rig, SDK, Delegados y ScriptableObjects</h3>

### 🎨 Rig y flujo de exportación (SDK entre Daz3D, Blender y Unity)

Se explicó el proceso de **Rigging en Blender**, incluyendo la estructura ósea, pesos de vértices y preparación para animación.  
Además, se revisó el uso del **SDK de Daz3D**, mostrando cómo exportar personajes hacia Blender y Unity con coherencia en:

- Escala y orientación del modelo.  
- Mapeo de materiales y texturas.  
- Conservación del esqueleto y pesos.  

Este flujo garantiza una integración sólida entre arte y motor, manteniendo una **pipeline profesional y reutilizable** para futuros proyectos.

---

### 🎥 Cinemachine: Cámaras Inteligentes en Unity

Se presentó el sistema **Cinemachine** de Unity, una herramienta poderosa que facilita la creación de cámaras dinámicas y profesionales **sin necesidad de programar desde cero**.

Entre sus ventajas:
- Permite crear **cámaras seguidoras**, **estáticas**, o **de enfoque automático**.  
- Ofrece control total sobre transiciones, límites y prioridades.  
- Mejora la narrativa visual sin afectar el rendimiento ni requerir scripts personalizados.

> 💡 Ideal para prototipos o proyectos donde la dirección de cámara debe ajustarse rápido, como en escenas cinemáticas o sistemas de cámara tipo *Resident Evil clásico*.

---

### ⚙️ Delegados, Action y Func en C#

Se abordó el funcionamiento de los **delegados** y su importancia dentro de la programación por eventos.  
Además, se detallaron las diferencias entre los tipos más comunes:

- **delegate:** Puede devolver cualquier tipo de dato y enlazar métodos dinámicamente.  
- **Action:** Un delegado que **no devuelve valores** (`void`).  
- **Func:** Similar a Action, pero **retorna un valor**, útil para cálculos o comprobaciones lógicas.

Estos conceptos fomentan un **código más modular, limpio y reutilizable**, reduciendo dependencias entre sistemas.

---

### 🧠 Uso de ScriptableObject y CreateAssetMenu

Se presentó el **ScriptableObject** como recurso clave para almacenar y gestionar datos sin necesidad de instanciar objetos en escena.  
Con el atributo `[CreateAssetMenu]`, se explicó cómo generar **activos personalizados** directamente desde el editor.

También se destacó el uso de **structs serializables** para agrupar variables relacionadas (posición, daño, nombre y efectos visuales), aprovechando la **herencia del ScriptableObject** para mejorar la organización y la eficiencia del proyecto.

> 💡 Este enfoque permite separar los datos de la lógica, creando sistemas más escalables y fáciles de mantener.

---

<h4 align="center">🚀 Contenido Futuro</h4>

En la próxima clase (**Clase N°2**) se explicará el uso de:
- **UnityEvent** y **Event**, aplicados al sistema de interacción y eventos personalizados.

---

<h4 align="center">🧑‍💻 Autor</h4>
<p align="center">
  Proyecto creado y mantenido por <b>Milton Castro</b>  
  <br>
  📧 <i>miltondeniscastro.1993@gmail.com</i>
</p>
