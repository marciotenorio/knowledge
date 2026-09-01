# Software Design

- [. . /Home](../../README.md)
- [SOLID](#solid)
- [Clean Architecture](#clean-architecture)
- [Hexagonal Architecture](#hexagonal-architecture)
- [Domain Driven Design](#domain-driven-design---ddd)
- [Grasp](#grasp---general-responsibility-assignment-software-pattern)
- [OOP - Object-Oriented Programming](#oop---object-oriented-programming)

# SOLID

## (S)ingle Responsibility
There should never be more than one reason for a class to change.
This principle aims to separate behaviors so that if bugs arise as a result of your change, it won’t affect other unrelated behaviors.

## (O)pen Close
Classes should be open to extension but closed for modification.

- **Extensibility**: New features can be added without modifying existing code.
- **Stability**: Reduces the risk of introducing bugs when making changes.
- **Flexibility**: Adapts to changing requirements more easily.

## (L)iskov Substitution Principle
Sates that functions that use pointers or references to base classes must be able to use pointers or references of derived classes without knowing it.

The main goal of LSP is to ensure that subclasses don't violate or weaken the behavioral meaning and guarantees of the base-class abstraction.

- **Polymorphism**: Enables the use of polymorphic behavior, making code more flexible and reusable.
- **Reliability**: Ensures that subclasses adhere to the contract defined by the superclass.
- **Predictability**: Guarantees that replacing a superclass object with a subclass object won't break the program.

## (I)nterface Segregation
States that clients should not be forced to depend upon interface methods that they do not use.

ISP splits interfaces that are very large into smaller and more specific ones so that clients will only have to know about the methods that are of interest to them.

## (D)ependency Inversion
- High-level modules should not import anything from low-level modules. Both should depend on abstractions (e.g., interfaces).

- Abstractions should not depend on details. Details (concrete implementations) should depend on abstractions.

**Tip:** There's a subtle distinction, though: DI doesn't automatically mean you're following DIP. You could inject a concrete class.

```text
IoC — general architectural idea
 ↓
"Who has control?"

DIP — design principle
 ↓
"Which direction should dependencies point?"

DI — concrete technique
 ↓
"How do I provide those dependencies?"
```


# Clean Architecture
https://engsoftmoderna.info/artigos/arquitetura-limpa.html

https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html

In general is called Clean Architecture because the core - entities and use cases - 
are "clean" of any technology.

![https://engsoftmoderna.info/artigos/arquitetura-limpa.html](../../assets/images/clean-arch.png)

- Entities and Use Cases
- Adapters
- Frameworks, libs, databases and others third party technologies. 
- Inverted Flow Control - External layer can depend of more internal layers (dependency rule)

> All details stay on frameworks and drivers.
Web is a detail, the database is a detail.
We keeping those technologies in the outer layer because it can do less danger.

# Hexagonal Architecture
https://engsoftmoderna.info/artigos/arquitetura-hexagonal.html

![https://engsoftmoderna.info/artigos/arquitetura-hexagonal.html](../../assets/images/hexagonal-arch.png)

Also know as Port and Adapters, follow the same idea of Clean Arch that need to be avoided technological dependence from frameworks, databases,
focus on business rules, be easiest to test, etc.

Divide system classes in two main groups:
- Domain classes, that are directly linked with business rules.
- Classes that are related with infra, databases, third party libs, etc.

Domain classes should not depend of infra, database, etc classes.

# Domain Driven Design - DDD
Focus on bring the domain problem concepts, naming conventions, contexts and terms to software building blocks, the ubiquitous language. 
Achieving this by collaboration with domain experts and understanding the complexities. 
DDD offer principles, practices and patterns do deal with this approach.

> Domain - this refers to the specific subject area or problem that the software system aims to address.
>
> Driven - the design of the software system is influenced by the features and needs of the domain. Rather than technical aspects.
>
> Design - the process of making a plan or blueprint of a software system (in this approach) driven by domain.

## Strategic Design in DDD
- Bounded Context - breaks down large, complex domains into smaller, more manageable parts. 
Separate ubiquitous language / clear boundaries between concepts (even with same name), like a module about library and other finance, when in the first has User and other user become Customer.
-  Context mapping - The process of defining relationships and interactions between different Bounded Contexts.
Understand where context overlap or integrate, establishing clear communication and agreements.
   - Shared Kernel - two contexts deliberately share a small part of the domain model or codebase.
   - Partnership — two bounded contexts cooperate closely and coordinate changes.       
   - Customer-Supplier - one context acts as the supplier (upstream), while another is the customer (downstream); the supplier takes the customer’s needs into account. Upstream listens to downstream needs.
-  Strategic Patterns - General guidelines for organizing the architecture of a software system in alignment with the problem domain.
   -  Aggregates - protects consistency inside domain model.
   -  Domain Events - something that happened in the domain that you want other parts of the same domain (in-process) to be aware of.
   -  Anti-Corruption Layer - contains all the logic necessary to translate between the two systems or bounded contexts.
-  Shared Kernel - a strategic pattern that identifies common areas between different Bounded Contexts and establishes a shared subset of the domain model.
- Architectural Layers: ui, application, domain, infra.
-  Ubiquitous Language - is a shared vocabulary that all stakeholders use consistently during software development, effectively capturing the relevant domain knowledge.
Common goal is to share domain language among teams.

## Tactical Design Patterns in DDD
- Entity - has unique identifier. They are more important concept.
- Rich entity - business rules together with entities, likes OOP pray.
- Value Object - has no unique identifier, they are characterized by its current state.
- Aggregates - are aggregation/composition of objects handled as a unique abstraction. They are persisted and deleted as a unique too. Has the root entity aggregate concept.
- Repository - they role is to get domain objects of database (even another source like other API?). Its a abstraction for persistence. They encapsulate translation/mapping between those objects.
- Factory - creational design pattern.
- Service - carries business rules independent of objects and is stateless.


# GRASP - General Responsibility Assignment Software Pattern

It is a set of guidelines that helps you decide **which class should be responsible for what** in an object-oriented system.

The core GRASP principles are:

1. **Information Expert**
   Give a responsibility to the class that already has the information needed to perform it.

   Example: an `Order` knows its items, so `Order` should calculate its own total.

2. **Creator**
   A class should create another object when it closely owns, contains, or uses it.

   Example: `Order` can create `OrderItem` objects.

3. **Controller**
   Use a class to receive requests from the UI/API and coordinate the work.

   Example:

   ```java
   class OrderController {
       void createOrder() {
           // coordinates the use case
       }
   }
   ```

4. **Low Coupling**
   Classes should have as few dependencies on other classes as possible.

   Bad:

   ```java
   class Order {
       MySQLDatabase db;
       StripePayment payment;
       EmailService email;
   }
   ```

   Better: depend on abstractions and keep responsibilities separated.

5. **High Cohesion**
   A class should have a small set of closely related responsibilities.

   Bad:

   ```java
   class User {
       saveToDatabase();
       sendEmail();
       generatePDF();
       calculateTax();
   }
   ```

   That class is doing too much.

6. **Polymorphism**
   When behavior varies by type, use polymorphism instead of lots of `if`/`switch` statements.

   Instead of:

   ```java
   if (paymentType == CREDIT_CARD) ...
   else if (paymentType == PIX) ...
   ```

   use:

   ```java
   interface Payment {
       void pay();
   }

   class CreditCardPayment implements Payment { ... }

   class PixPayment implements Payment { ... }
   ```

7. **Pure Fabrication**
   Sometimes you create a class that does not represent a real-world domain object, just to keep the design clean.

   For example:

   ```java
   class UserRepository {
       void save(User user) { ... }
   }
   ```

   `UserRepository` isn't really a business object, but it's useful because it keeps persistence logic away from `User`.

8. **Indirection**
   Introduce an intermediate object to reduce coupling between two components.

   For example:

   ```text
   Order → PaymentService → Stripe
   ```

   instead of:

   ```text
   Order → Stripe
   ```

9. **Protected Variations**
   Identify things that are likely to change and hide them behind a stable interface.

   For example:

   ```java
   interface PaymentGateway {
       void charge();
   }
   ```

   Then you can have:

   ```text
   StripePaymentGateway
   PayPalPaymentGateway
   MercadoPagoPaymentGateway
   ```

   Your business logic doesn't care which one is used.

A useful way to think about **GRASP vs SOLID** is:

* **GRASP:** “Where should this responsibility go?”
* **SOLID:** “How should I structure these classes so the design stays maintainable?”

For example, if you're building an e-commerce system and ask:

> Who should calculate the order total?

GRASP says: use **Information Expert** → probably `Order`, because `Order` already knows its items.

```java
class Order {
    List<OrderItem> items;

    Money total() {
        return items.stream()
            .map(OrderItem::subtotal)
            .reduce(Money.ZERO, Money::add);
    }
}
```

So the main idea to remember is:

**GRASP = principles for deciding which object gets which responsibility.**

[Article on Wikipedia about GRASP](https://en.wikipedia.org/wiki/GRASP_(object-oriented_design))


# OOP - Object-Oriented Programming

## Fundamentals

**Class and Object:** A class defines the structure and behavior of a type. An object is a concrete instance of that class created at runtime.

**State and Behavior:** Objects combine state, represented by fields or properties, with behavior, represented by methods.

**Constructor:** Defines how an object is created and helps guarantee that it starts in a valid state.

**Access Modifiers:** Control which parts of an object are accessible from outside, such as `public`, `private`, and `protected`.

**Encapsulation:** Protects an object's internal state and exposes controlled operations instead of allowing unrestricted modification.

**Abstraction:** Exposes what an object can do while hiding unnecessary implementation details.

**Inheritance:** Allows one type to specialize another and reuse or extend its behavior. It creates strong coupling and should be used only when a real "is-a" relationship exists.

**Polymorphism:** Allows different implementations to be used through the same abstraction, with behavior determined by the concrete object.

**Types of Polymorphism:**

* **Subtype Polymorphism:** A subtype can be used wherever its base type or interface is expected. Method overriding and dynamic dispatch are common examples.
* **Parametric Polymorphism:** The same code works with different types through type parameters or generics.
* **Ad Hoc Polymorphism:** The same operation has different implementations for different types, commonly through method overloading or operator overloading.
* **Coercion Polymorphism:** A value is implicitly or explicitly converted from one type to another so that an operation can be applied.

## Object Relationships

**Association:** A general relationship where one object knows about or interacts with another.

**Aggregation:** A weak "has-a" relationship where the child object can exist independently from its owner.

**Composition:** A strong "has-a" relationship where one object owns another object's lifecycle.

**Composition over Inheritance:** Prefer combining objects with focused responsibilities instead of building deep inheritance hierarchies.

**Delegation:** An object assigns part of its behavior to another object instead of implementing everything itself.

## Contracts and Abstractions

**Interface:** Defines a contract that multiple implementations can satisfy without defining how the behavior must be implemented.

**Abstract Class:** Defines a base abstraction that may contain shared state, implemented behavior, and abstract operations.

**Interface vs Abstract Class:** Prefer interfaces for contracts and flexibility. Use abstract classes when related types genuinely share behavior or state.

**Method Overloading:** Multiple methods share the same name but have different parameter signatures, normally resolved at compile time.

**Method Overriding:** A subtype replaces inherited behavior, enabling runtime polymorphism.

**Static vs Dynamic Dispatch:** Static dispatch determines the called method at compile time, while dynamic dispatch selects the implementation at runtime.

## Good Object Design

**Cohesion:** A class should contain responsibilities that naturally belong together.

**Coupling:** Objects should minimize unnecessary knowledge and dependencies on other objects.

**Object Collaboration:** OOP systems are built around objects sending requests to each other and collaborating to perform larger behaviors.

**Tell, Don't Ask:** Prefer telling an object what to do instead of extracting its data and implementing its behavior elsewhere.

**Law of Demeter:** Objects should communicate mainly with their direct collaborators instead of navigating long chains of dependencies.

**Immutability:** An immutable object's state cannot change after creation, reducing side effects and simplifying reasoning and concurrency.

**Invariant:** A rule that must always remain true for an object. Good object design prevents invalid states from being created.

## Identity and Equality

**Object Identity:** Two objects may contain the same data while still representing different entities.

**Value Equality:** Two objects are considered equal when their relevant values are equal.

**Value Object:** An object defined entirely by its values, such as `Money`, `Coordinate`, or `DateRange`.

**Entity:** An object defined primarily by its identity, even when its attributes change over time.

## SOLID

**Single Responsibility Principle:** A class should have one clear responsibility and one main reason to change.

**Open/Closed Principle:** Software should allow new behavior to be added without constantly modifying stable existing code.

**Liskov Substitution Principle:** A subtype must preserve the behavioral expectations of the type it replaces.

**Interface Segregation Principle:** Prefer small and focused interfaces instead of forcing clients to depend on operations they do not use.

**Dependency Inversion Principle:** High-level code should depend on abstractions rather than concrete implementations.

## Intermediate and Advanced Concepts

**Dependency Injection:** Dependencies are provided from outside an object instead of being created internally, reducing coupling and improving testability.

**Upcasting:** Treating an object of a derived type as an instance of a base type or interface. Upcasting is generally implicit and safe because the derived type satisfies the base contract.

**Downcasting:** Treating a reference to a base type as a more specific derived type. Downcasting is potentially unsafe because the referenced object may not actually be an instance of the target subtype, so it should be checked or avoided when possible.

**Covariance:** Allows a more specific type to be used where a more general output type is expected. It is commonly associated with producers, return values, and safe upcasting.

**Contravariance:** Allows a more general type to be used where a more specific input type is expected. It is commonly associated with consumers and parameter types.

**Upcasting, Downcasting, and Variance:** Upcasting and downcasting describe conversions between individual object references in an inheritance hierarchy. Covariance and contravariance describe how compatible type relationships behave in generic or functional abstractions. Covariance generally preserves the direction of subtype relationships, while contravariance reverses it. Neither concept makes every downcast safe.

**Rich Domain Model:** Business objects contain both state and meaningful business behavior.

**Anemic Domain Model:** Domain objects mainly contain data while business behavior is implemented elsewhere. This can be appropriate for simple systems but problematic in complex domains.

**Domain Modeling:** Models software around business concepts, behaviors, rules, and relationships instead of simply reproducing database structures.

**Aggregate:** In Domain-Driven Design, a group of related objects that maintains consistency through a single aggregate root.

**Design Patterns:** Reusable solutions to recurring design problems. Important examples include Strategy, Factory, Decorator, Adapter, Observer, Command, State, and Template Method. The goal is understanding the problem each pattern solves, not memorizing implementations.

## Advanced Perspective

**Object-Oriented Design:** Good OOP is primarily about defining responsibilities, boundaries, collaborations, and contracts between objects rather than simply creating classes.

**Behavior over Data:** Prefer objects that protect their state and expose meaningful operations instead of becoming passive containers of getters and setters.

**OOP Trade-offs:** OOP is one programming model among several. Functional, procedural, and data-oriented approaches may produce simpler solutions depending on the problem.
