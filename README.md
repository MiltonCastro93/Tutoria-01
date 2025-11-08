<h1 align="center">🎓 Tutoria-01</h1>
<p align="center">
  Proyecto educativo en constante evolución, donde se documentan clases técnicas sobre <b>Unity</b>, <b>Blender</b> y <b>programación en C#</b>.
  <br>
  Cada clase aborda distintos conceptos teóricos y prácticos aplicados al desarrollo de videojuegos.
</p>

---

<h3 align="center">📘 Clase N°1 — Rig, SDK y Delegados en Unity</h3>

### 🎨 Rig y flujo de exportación (SDK entre Daz3D, Blender y Unity)

Se explicó el proceso de **Rigging en Blender**, incluyendo la estructura ósea, pesos de vértices y preparación para animación.  
Además, se revisó el uso del **SDK de Daz3D**, demostrando cómo exportar personajes hacia Blender y Unity, manteniendo coherencia en:

- Escala y orientación del modelo.  
- Mapeo de materiales y texturas.  
- Conservación del esqueleto y pesos.  

Este flujo garantiza una correcta **integración entre arte y motor**, permitiendo una pipeline profesional de trabajo.

---

### ⚙️ Delegados, Action y Func en C#

Se abordó el funcionamiento de los **delegados** y su rol dentro de la **programación por eventos**.  
También se explicó la diferencia entre los tipos más comunes:

- **delegate:** Puede devolver cualquier tipo de dato y permite enlazar métodos dinámicamente.  
- **Action:** Es un delegado especializado que **no devuelve valores** (`void`).  
- **Func:** Similar a Action, pero **retorna un valor**, ideal para operaciones lógicas o cálculos.

Estos conceptos promueven un **código más modular, flexible y desacoplado**, facilitando el mantenimiento y la reutilización de métodos en distintos sistemas.

---

### 🧠 Uso de ScriptableObject y CreateAssetMenu

Se presentó el **ScriptableObject** como una herramienta para almacenar datos persistentes sin necesidad de instanciar GameObjects.  
A través del atributo `[CreateAssetMenu]`, se mostró cómo generar **activos personalizados** desde el editor de Unity.
También se explicó el uso de **structs serializables** para agrupar datos relacionados (por ejemplo, posición, daño, nombre y efectos visuales), aprovechando la **herencia de ScriptableObject** para mejorar la organización y la eficiencia en la carga de información.

> 💡 Este enfoque permite una arquitectura más limpia, donde los datos son independientes de los objetos de escena.

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
