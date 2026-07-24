<!-- markdownlint-disable-next-line MD033 MD041 -->
<img alt="UCU" src="https://www.ucu.edu.uy/plantillas/images/logo_ucu.svg"
width="150"/>

# Universidad Católica del Uruguay

## Programación II

# Plantilla de ejercicios

## Descripción

Esta plantilla proporciona una estructura base para los ejercicios de
Programación II. Incluye la configuración necesaria para desarrollar
aplicaciones en C# con buenas prácticas de programación, pruebas automatizadas y
documentación.

La configuración es análoga a la de la [plantilla de
proyectos](https://github.com/ucudal/PII_ProjectTemplate).

La plantilla está pensada para ser utilizada como base de los ejercicios de
Programación II. Cuando creamos un nuevo ejercicio, usamos esta plantilla como
punto de partida. Para los ejercicios existentes, podemos usar extensiones de
Visual Studio Code como [Compare
Folders](https://marketplace.visualstudio.com/items?itemName=moshfeu.compare-folders)
o [Diff
Folders](https://marketplace.visualstudio.com/items?itemName=L13RARY.l13-diff),
o herramientas como [Beyond Compare](https://www.scootersoftware.com), para
pasar la configuración de esta plantilla al ejercicio existente.

## Estructura

Los archivos README.md de los ejercicios **deben** incluir:

* El o los temas involucrados en el ejercicio; idealmente con vínculos al
  teórico correspondiente.

* La consigna, dividida en partes, de lo que se espera que los estudiantes
  hagan.

* Una rúbrica que evaluación que sirva tanto para guiar a los estudiantes en la
  resolución del ejercicio como a los profesores para la corrección.

## Uso de ![GitHub Copilot](https://img.shields.io/badge/GitHub%20Copilot-000?logo=githubcopilot&logoColor=fff)

La plantilla está configurada para usar GitHub Copilot, tanto por los profesores
como por los estudiantes.

La configuración para controlar el comportamiento de lo que puede o no hacer
Copilot, y de los aspectos genéricos relacionados con el curso, está en el
archivo [`copilot-instructions.md`](/.github/copilot-instructions.md). Para
ejercicios específicos, puede ser necesario ajustar estas instrucciones.

La configuración para controlar cómo Copilot hace la revisión de los archivos
`.csproj` está en el archivo
[`csproj.instructions.md`](/.github/instructions/csproj.instructions.md).

La configuración para controlar cómo Copilot hace la revisión de los casos de
prueba está en el archivo
[`tests.instructions.md`](/.github/instructions/csproj.instructions.md).

El archivo
[`README.instructions.md`](.github/instructions/README.instructions.md) tiene
instrucciones para que Copilot asegure la consistencia y corrección de las
consignas de ejercicios en esos archivos.

> [!IMPORTANT]
> Hay que copiar el contenido del archivo [`COPILOT.md`](./COPILOT.md) al final
> del archivo `README.md`; ese archivo tiene las instrucciones para que los
> estudiantes puedan usar Copilot.

## Corrección automática

La plantilla permite corrección automática con GitHub Copilot y el complemento
de Visual Studio Code [Grading
Agent](https://github.com/ucudal/GradingAgent_VSCode_Extension).

> [!IMPORTANT]
> El agente para corrección automática no está incluido en esta plantilla, sino
> qu está disponible como parte del complemento **Grading Agent**
> [aquí](https://github.com/ucudal/GradingAgent_VSCode_Extension/blob/main/assets/grade.agent.md).

Para que el complemento **Grading Agent** funcione, el archivo README.md del
ejercicio debe tener una rúbrica de evaluación.

> [!IMPORTANT]
> El archivo README.md **debe** incluir una rúbrica de evaluación
> independientemente de que usemos corrección automática o no.
<!--  -->
> [!TIP]
> Las rúbricas de evaluación pueden ser generadas con GitHub Copilot. Hay que
> pasar a Copilot los objetivos de aprendizaje relacionados con el ejercicio y
> la consigna, más un ejemplo de rúbrica como el que aparece [a
> continuación](#ejemplo-de-rúbrica).

## Ejemplo de rúbrica

A continuación, aparece un ejemplo de rúbrica de evaluación y, debajo, de
cálculo de puntos en base a esa rúbrica.

| Criterio | Ponderación | Experto | En desarrollo | Incipiente | Insuficiente |
| --- | --- | --- | --- | --- | --- |
| **Funcionalidad** | 40% | Cumple con la consigna correctamente y de forma consistente. | Cumple casi toda la consigna; fallos menores. | Funciona parcialmente o con errores frecuentes. | No funciona o no compila. |
| **Aplicación de Expert** | 20% | Clases con responsabilidades claras, una sola razón de cambio; se evidencia Expert | Algunas responsabilidades bien distribuidas, otras no | Distribución confusa o acoplada | No hay diseño por responsabilidades |
| **Aplicación de SRP** | 20% | Aplica SRP/Expert explícitamente y los justifica. | Aplica algunos criterios pero sin consistencia o explicación parcial | Aplicación débil o poco justificada | No aplica ni justifica |
| **Diseño orientado a objetos** | 10% | Clases y colaboraciones coherentes con el dominio | Diseño razonable con algunas inconsistencias | Diseño pobre; falta claridad en relaciones | Diseño inexistente o incorrecto |
| **Comentarios de justificación** | 5% | Todas las clases justificadas con claridad | La mayoría justificadas de forma aceptable | Pocas justificaciones o poco claras | Sin justificaciones o incorrectas |
| **Calidad y convenciones C#** | 5% | Nombres, formato y estilo consistentes | Algunos desvíos menores | Múltiples problemas de estilo | Estilo y convenciones ignoradas |
