# Builder Pattern - Springfield Citizens 🏗️👨‍👩‍👧‍👦

A practical and educational implementation of the **Builder Pattern** in C# targeting .NET 10, using characters inspired by The Simpsons to illustrate how different builders produce different representations of the same complex object.

## 📖 Overview

This project shows how to separate the construction of a complex object (`SpringfieldCitizen`) from its representation. A `Director` orchestrates the build process while multiple `ConcreteBuilder` implementations provide different ways to assemble the object (for example, `HomerBuilder` and `MrBurnsBuilder`).

The pattern helps keep object creation logic centralized and modular, making it easy to add new variants (e.g., `BartBuilder`, `MargeBuilder`) without changing the Director or client code.

## 🔑 Key Components

### 1. Interface: `ISpringfieldCitizenBuilder`
Defines the steps required to build a `SpringfieldCitizen` (e.g., `BuildName()`, `BuildOccupation()`, `BuildTraits()`, `GetResult()`).

### 2. Director: `SpringfieldDirector`
Orchestrates the building sequence by calling builder steps in the correct order.

### 3. Concrete Builders
- `HomerBuilder` — Builds a `SpringfieldCitizen` that represents Homer Simpson (lazy, loves donuts).
- `MrBurnsBuilder` — Builds a `SpringfieldCitizen` for Charles Montgomery Burns (wealthy, ruthless).
- Extendable: add new builders like `MargeBuilder`, `BartBuilder`, etc.

### 4. Product: `SpringfieldCitizen`
The final object assembled by builders. It typically contains properties such as `Name`, `Occupation`, and `Traits`.

## 🚀 Benefits of this Design

- Loose coupling between construction and representation.
- Clear separation of responsibilities: Director handles the sequence; Builders handle the details.
- Easy to extend: new character builders can be added with minimal changes.
- Better testability: builders can be unit tested independently.


## 🎯 Learning Outcomes

After studying this project you will understand:
- The Builder Pattern and when to use it
- How to separate construction logic from object representation
- How to create different representations with the same construction process
- How to extend the system with new builders without modifying existing code

## 📝 Notes & Extensions

- Consider adding builders for other Springfield characters (Bart, Marge, Lisa).
- The Director can accept configuration flags to vary the sequence (e.g., optional steps).
- Use `Build()` or `GetResult()` on builders to return the final `SpringfieldCitizen`.

Happy building in Springfield! 🍩🏛️

