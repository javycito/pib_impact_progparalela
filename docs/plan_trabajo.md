Contexto
 
- Proyecto: Sistema en C# para cargar datos CSV (países, sectores, aranceles), simular el impacto en el PIB, paralelizar cálculos, analizar resultados y medir rendimiento.
- Equipo: Erick, Rosa (líder), Enjher, Omar, Emmanuel.
- Plazo: 21 de abril de 2025 (entrega y exposición, aunque posible 23).
- Semanas de trabajo: 7-13 de abril, 14-20 de abril.
- Commits: Mínimo 3 por integrante por semana (6 totales por persona), apuntando a ~30 commits totales.
- Repositorio: Creado con /src, /docs, /tests, metrics. Usando GitHub con ramas y PRs.
- Lenguaje: C# (TPL para paralelismo, CsvHelper para CSV, xUnit para pruebas).
- Líder: Rosa, encargada de coordinar tareas, reuniones, revisar PRs y evaluar al equipo.
 
 
 
 


 
Distribución de Tareas
 
1. Erick Francisco De la Rosa Toribio
Responsabilidad principal: Estructura y Carga de Datos
  - Tarea 1: Configurar la solución C# en Visual Studio (.csproj, dependencias como CsvHelper, xUnit). Crear estructura inicial en /src.
Commit: "Configurada solución C# con dependencias iniciales\nCo-authored-by: ErickFranciscoDeLaRosaToribio".
  - Tarea 2: Implementar clases modelo (Pais, SectorEconomico, Arancel) con propiedades básicas (por ejemplo, Pais: Nombre, PIB).
Commit: "Implementadas clases Pais, SectorEconomico, Arancel\nCo-authored-by: ErickFranciscoDeLaRosaToribio".
  - Tarea 3: Desarrollar la función para cargar archivos CSV con CsvHelper, incluyendo manejo de errores.
Commit: "Agregada carga de CSV con manejo de errores\nCo-authored-by: ErickFranciscoDeLaRosaToribio".
  - Tarea 4: Agregar soporte para cargar JSON (usando System.Text.Json) como alternativa.
Commit: "Añadido soporte para carga de JSON\nCo-authored-by: ErickFranciscoDeLaRosaToribio".
  - Tarea 5: Escribir pruebas unitarias para las clases y carga de datos (verificar formatos, datos vacíos).
Commit: "Agregadas pruebas unitarias para carga de datos\nCo-authored-by: ErickFranciscoDeLaRosaToribio".
  - Tarea 6: Redactar la sección del documento principal sobre implementación técnica (sección 5 del PDF) en ‘/docs’.
Commit: "Añadida documentación de implementación técnica\nCo-authored-by: ErickFranciscoDeLaRosaToribio".
Rama que va a crear/utilizar para trabajar: feature/carga-datos 
Archivos: /src/Models, /src/Data, /tests, /docs 
Rol: Provee la base de datos (esencial para otros módulos). Coordina con Rosa para integrar
 
2. Rosa Angelica Sánchez Franco – Líder
Responsabilidad principal: Simulación del Impacto en el PIB + Coordinación del Equipo
  - Tarea 1: Implementar la lógica base para calcular el impacto de aranceles en el PIB (por ejemplo, PIB_ajustado = PIB * (1 - tasa_arancel)).
Commit: "Implementada lógica de simulación de impacto en PIB\nCo-authored-by: RosaAngelicaSanchezFranco".
  - Tarea 2: Configurar el flujo de GitHub (etiquetas, reglas de PR, asignar revisores) y redactar un plan de trabajo en /docs.
Commit: "Configurado flujo de GitHub y plan de trabajo\nCo-authored-by: RosaAngelicaSanchezFranco".
  - Tarea 3: Organizar la primera reunión (definir horarios, herramientas como Discord/Teams) y documentar acuerdos en /docs.
Commit: "Documentada primera reunión y acuerdos\nCo-authored-by: RosaAngelicaSanchezFranco".
  - Tarea 4: Extender la simulación para proyectar el impacto en 5 años (modelo de crecimiento compuesto).
Commit: "Agregada proyección de PIB a 5 años\nCo-authored-by: RosaAngelicaSanchezFranco".
  - Tarea 5: Redactar las secciones del documento principal sobre introducción, objetivos y trabajo en equipo (secciones 1 y 7 del PDF).
Commit: "Añadida documentación de introducción y trabajo en equipo\nCo-authored-by: RosaAngelicaSanchezFranco".
  - Tarea 6: Preparar diapositivas de la exposición (introducción, problema, coordinación) y liderar el ensayo.
Commit: "Agregadas diapositivas de exposición para coordinación\nCo-authored-by: RosaAngelicaSanchezFranco".
Rama que va a crear/utilizar para trabajar: feature/simulacion-pib 
Archivos: /src/Simulation, /docs, /docs/exposicion 
Rol de líder:
- Coordinar reuniones semanales.
- Revisar PRs de todos (asegurar calidad).
- Evaluar al equipo (compromiso, calidad, colaboración).
- Asegurar que se cumpla el plazo del 21 de abril
 
 3. Enjher Javier Agüero Ovalles
Responsabilidad principal: Pruebas Unitarias y Documentación de Resultados
  - Tarea 1: Crear pruebas unitarias iniciales para validar las clases de Erick (por ejemplo, verificar propiedades de Pais, Arancel) usando xUnit. Usa datos ficticios si Erick no ha terminado.
Commit: "Agregadas pruebas unitarias iniciales para modelos\nCo-authored-by: EnjherJavierAgüeroOvalles".
  - Tarea 2: Escribir un script en /tests para generar datos ficticios (CSV con países y aranceles) para pruebas.
Commit: "Añadido script de generación de datos ficticios\nCo-authored-by: EnjherJavierAgüeroOvalles".
  - Tarea 3: Redactar la sección del documento principal sobre descripción del problema (sección 2 del PDF) en /docs, explicando el contexto económico.
Commit: "Añadida documentación de descripción del problema\nCo-authored-by: EnjherJavierAgüeroOvalles".
  - Tarea 4: Ampliar las pruebas unitarias para cubrir la simulación de Rosa (por ejemplo, verificar cálculos de PIB).
Commit: "Agregadas pruebas unitarias para simulación\nCo-authored-by: EnjherJavierAgüeroOvalles".
  - Tarea 5: Documentar los resultados de las pruebas en /docs (por ejemplo, tabla con casos probados).
Commit: "Añadida documentación de resultados de pruebas\nCo-authored-by: EnjherJavierAgüeroOvalles".
  - Tarea 6: Preparar una diapositiva para la exposición sobre las pruebas realizadas.
Commit: "Agregada diapositiva de exposición sobre pruebas\nCo-authored-by: EnjherJavierAgüeroOvalles".
 




Rama que va a crear/utilizar para trabajar: feature/pruebas 
Archivos: /tests, /docs, /docs/exposicion 
Rol: Gestiona las pruebas unitarias y la documentación de resultados, coordinando con Rosa para validar los módulos y contribuir al informe final.

4. Omar Ulises Ovalles Veloz
Responsabilidad principal: Paralelización de la Simulación
  - Tarea 1: Implementar paralelización inicial con Parallel.ForEach para simular el impacto en múltiples países, usando datos ficticios si Erick no está listo.
Commit: "Implementado Parallel.ForEach para simulación\nCo-authored-by: OmarUlisesOvallesVeloz".
  - Tarea 2: Agregar sincronización con ConcurrentBag para evitar conflictos en los resultados.
Commit: "Añadida sincronización con ConcurrentBag\nCo-authored-by: OmarUlisesOvallesVeloz".
  - Tarea 3: Escribir pruebas iniciales para la paralelización (verificar que los resultados sean correctos).
Commit: "Agregadas pruebas para paralelización\nCo-authored-by: OmarUlisesOvallesVeloz".
  - Tarea 4: Implementar una segunda estrategia de paralelización con Task.WhenAll para comparar rendimiento.
Commit: "Añadida paralelización con Task.WhenAll\nCo-authored-by: OmarUlisesOvallesVeloz".
  - Tarea 5: Redactar la sección del documento principal sobre diseño de la solución (sección 4 del PDF, incluyendo diagrama).
Commit: "Añadida documentación de diseño de solución\nCo-authored-by: OmarUlisesOvallesVeloz".
  - Tarea 6: Preparar diapositivas para la exposición sobre paralelización.
Commit: "Agregadas diapositivas de exposición sobre paralelización\nCo-authored-by: OmarUlisesOvallesVeloz".
 
Rama que va a crear/utilizar para trabajar: feature/paralelismo 
Archivos: /src/Simulation, /tests, /docs, /docs/exposicion 
Rol: Maneja la paralelización, una tarea técnica clave, coordinando con Rosa para integrarla.


5. Emmanuel Sanchez Bonilla
Responsabilidad principal: Análisis, Reportes y Métricas
  - Tarea 1: Implementar funciones para analizar resultados (PIB total afectado, sectores más impactados).
Commit: "Implementadas funciones de análisis de resultados\nCo-authored-by: EmmanuelSanchezBonilla".
   - Tarea 2: Crear una función para generar un informe en CSV con métricas globales.
Commit: "Agregada generación de informe en CSV\nCo-authored-by: EmmanuelSanchezBonilla".
  - Tarea 3: Implementar métricas iniciales (tiempo de ejecución con Stopwatch).
Commit: "Añadidas métricas de tiempo de ejecución\nCo-authored-by: EmmanuelSanchezBonilla".
  - Tarea 4: Agregar visualización simple (tabla en consola o CSV para gráficos). Commit: "Añadida visualización de resultados\nCo-authored-by: EmmanuelSanchezBonilla".
  - Tarea 5: Redactar la sección del documento principal sobre evaluación de desempeño (sección 6 del PDF).
Commit: "Añadida documentación de evaluación de desempeño\nCo-authored-by: EmmanuelSanchezBonilla".
  - Tarea 6: Generar gráficas comparativas (secuencial vs. paralela) en /metrics.
Commit: "Añadidas gráficas comparativas en /metrics\nCo-authored-by: EmmanuelSanchezBonilla".
 
 Rama que va a crear/utilizar para trabajar: feature/analisis-metricas
Archivos: /src/Analysis, /metrics, /docs, /docs/exposicion 
Rol: Cierra el ciclo con análisis y métricas, dependiendo de la simulación y paralelización.
 

Rol de Rosa como Líder
Coordinación:
  - Organiza reuniones para verificar avances.
  - Define dependencias (por ejemplo, Erick termina clases primero).
  - Usa GitHub Issues o un tablero (Trello, Excel) para seguir tareas (Si desea).
Revisión:
  - Revisa todos los PRs antes de fusionar a main.
  - Asegura que los commits incluyan “Co-authored-by”.
Evaluación:
  - Evalúa a cada integrante (compromiso, calidad, colaboración) al final.
  - Recopila evaluaciones del equipo hacia ella.
Exposición:
  - Lidera la preparación de diapositivas y el ensayo (20 de abril).
  - Presenta la introducción y el contexto en la exposición.
 
 
 
 
 
Flujo de Trabajo con GitHub
Dependencias:
  - Erick empieza primero (clases y carga de datos), ya que todos usan sus modelos.
  - Enjher puede trabajar con datos ficticios (CSV generado en pruebas) desde el inicio, haciendo las pruebas.
  - Rosa y Omar esperan las clases de Erick para la simulación y paralelización, pero pueden usar datos ficticios al principio.
  - Emmanuel depende de Rosa y Omar para analizar resultados, pero puede empezar métricas de tiempo con pruebas iniciales.
 
Ramas y PRs:
  - Cada integrante crea una rama (feature/pruebas, feature/simulacion-pib, etc.).
  - Suben commits frecuentes (3 por semana) con “Co-authored-by: NombreApellido”.
  - Crean PRs parciales (WIP) para guardar progreso  (Si desean), actualizándolos al integrar el trabajo de Erick.
  - El resto, pero específicamente Rosa y Enjhe,r revisan y aprueban PRs antes de fusionar a main.
 







 
 
Documento Principal
- Sección 1: Introducción (Rosa): Justificación, objetivos.
- Sección 2: Descripción del Problema (Enjher): Contexto económico.
- Sección 3: Cumplimiento de Requisitos (Rosa): Coordina aportes de todos.
- Sección 4: Diseño de la Solución (Omar): Arquitectura, diagrama.
- Sección 5: Implementación Técnica (Erick): Código, sincronización.
- Sección 6: Evaluación de Desempeño (Emmanuel): Métricas.
- Sección 7: Trabajo en Equipo (Rosa): Reparto, herramientas.
- Sección 8: Conclusiones (todos): Aprendizajes, retos.
- Sección 9: Referencias (Rosa): Fuentes técnicas.
- Sección 10: Anexos (Erick): Manual, capturas.
- Portada e Índice (Rosa): Detalles del equipo, fecha.
 
Exposición (21 o 23 de abril)
- Ensayo: 20 de abril, liderado por Rosa.
- Rosa (líder): Introduce el proyecto, explica simulación, coordina.
- Erick: Presenta carga de datos y modelos.
- Omar: Muestra paralelización y diseño.
- Enjher: Explica pruebas unitarias y datos de prueba.
- Emmanuel: Presenta análisis, métricas, gráficas.
- Diapositivas: En /docs/exposicion, cada uno aporta 1-2 slides.
