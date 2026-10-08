# Actividad 1: Calculadora con métodos

## Datos del estudiante

| Campo       | Detalle                            |
|-------------|------------------------------------|
| Nombre      | Pedro Yunior                       |
| Matrícula   | 2025-1422                          |
| Materia     | Programación Básica                |
| Sección     | ISW-122-2                          |
| Profesor    | Gamalier Reyes Del Carmen          |
| Universidad | Universidad Central del Este (UCE) |

## Descripción

Programa de consola en **C#** que funciona como una calculadora básica. Pide dos números al usuario y muestra la suma, resta, multiplicación, división y potencia. Todo el trabajo se divide en métodos, y el `Main` solo los llama y muestra los resultados.

## Métodos implementados

| Método | Descripción |
|--------|-------------|
| `Sumar(double a, double b)` | Retorna la suma de los dos números. |
| `Restar(double a, double b)` | Retorna la resta de los dos números. |
| `Multiplicar(double a, double b)` | Retorna la multiplicación de los dos números. |
| `Dividir(double a, double b)` | Retorna la división. Si el divisor es 0, muestra un mensaje de error. |
| `LeerNumero(string mensaje)` | Muestra el mensaje y retorna el número digitado. |
| `Potencia(double baseNum, double exponente)` | **Reto extra:** usa `Math.Pow(base, exponente)`. |

## Cómo ejecutar

1. Abrir Visual Studio (o cualquier IDE compatible con C#).
2. Crear un proyecto de **Aplicación de consola** y reemplazar su `Program.cs` por el de esta entrega.
3. Ejecutar con `F5`, o desde la terminal:

```bash
dotnet run
```

## Ejemplos de ejecución

### Ejemplo 1: Ejecución normal

<img width="480" height="307" alt="Captura de pantalla 2026-10-08 171121" src="https://github.com/user-attachments/assets/3394e232-2e6c-47ee-890e-5a65b4789da5" />


### Ejemplo 2: División entre cero

Cuando el segundo número es `0`, el método `Dividir` valida la operación y muestra un mensaje de error en lugar de calcular el resultado.

<img width="708" height="305" alt="Captura de pantalla 2026-10-08 171238" src="https://github.com/user-attachments/assets/11357209-6f58-4a67-8335-1e4382662962" />


## Archivo de entrega

- `Program.cs`
