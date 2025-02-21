# Java Reference

## Summary

- [. . /Languages](../languages.md)
- [Basics](#basics)
- [OOP](#object-oriented-programming)
- [Generics](#generics)
- [Keywords](#keywords)

# Basics

Strongly typed, without pointers and with garbage collector. Platform agnostic (run inside JVM).

The main flow to run a java program is compile and interpret, because:
1.  Compiled: .java source code => bytecode, the .class files
2.  Interpreted: The JVM interpreted the bytecode generated and run your program

> Access and non-access modifiers [here](https://www.geeksforgeeks.org/access-and-non-access-modifiers-in-java/).

## Upcasting, Downcasting, Static and Dynamic Type

Remember about: upcasting and downcasting.
- O tipo declarado de uma variável é seu tipo estático. 
- O tipo do objeto ao qual uma variável se refere é seu tipo dinâmico.
- Uma referência para a superclasse pode apontar para um objeto da subclasse. 
	- Ex: Todo o carro é veículo, mas nem todo veículo é carro. Pode ser uma bicicleta.
- Uma variável pode conter objetos de seu tipo declarado ou de qualquer subtipo declarado. Upcasting

[Example](./learn-java/src/main/java/br/com/updowncasting/UpDownCastingMain.java)
```java
//Upcasting
Item up = new CD("Oi upcasting", 10, 10F);

//Not works
//CD down = new Item("Title down", 10);

//Works downcasting
CD down = new CD("CD Oi", 10, 10F);
Item itemDown = down;
String.valueOf(itemDown.playingTime);

//Upcasting and casting to get subclass method.
//Need to do this because late binding searching for the method first in Item
Item upying = new CD("Oi upying", 10, 10F);
((CD)upying).print();
```

## equals and hashCode 

Always override ``hashCode`` when you override ``equals``. You must override ``hashCode`` in every class that overrides ``equals``. If you fail to do so, your class will violate the general contract for hashCode, which will prevent it from functioning properly in collections such as HashMap and HashSet.

### equals

In Effective Java, Joshua Bloc gives a directive based on the ``Object.equals()`` to implement ``equals`` methods. Following those guidelines, an ``equals`` method for a non-null must implement:

- Reflexive - Equals to itself.
- Symmetric - Be ``a`` and ``b`` objects of the same type, always ``a.equals(b)`` should return ``true`` iff ``b.equals(a)`` return ``true``.
- Transitive - Be ``a``, ``b`` and ``c`` object of the same type ``a.equals(b)`` return ``true``, ``b.equals(c)`` return ``true`` must imply that  ``a.equals(c)`` return ``true``.
- Consistent - Consistently return true or false to same operation being made multiple times.
- When compared with ``null``, return ``false``.

[Example](./learn-java/src/main/java/br/com/oopbasics/Car.java#L41)

### hashCode

The key provision that is violated when you fail to override hashCode is the second one: equal objects must have equal hash codes.
Here is the contract, adapted from the Object specification:

- When the hashCode method is invoked on an object repeatedly during an execution of an application, it must consistently return the same value, provided no information used in equals comparisons is modified. This value need not remain consistent from one execution of an application to another. 
- If two objects are equal according to the equals(Object) method, then calling hashCode on the two objects must produce the same integer result. 
- If two objects are unequal according to the equals(Object) method, it is not required that calling hashCode on each of the objects must produce distinct results. However, the programmer should be aware that producing distinct results for unequal objects may improve the performance of hash tables.

[Example](./learn-java/src/main/java/br/com/oopbasics/Car.java#L47)

## Exceptions

The superclass is ``Throwable`` exceptions hierarchy, so ``throw`` and ``throws`` keywords can throw and declare respectively class that is subclass.

For compile time puporses, only ``Error`` and ``RuntimeException`` and it's subclasses are ``unchecked``.
All other is ``checked``.

- ``Exception``: Things that can be catched for the application.
- ``Error``: Problems in JVM. The application can't recover, you are running over abnormal conditions that
must never occur.
- ``RuntimeException``: Can be throw in normal operation like ``NullPointerException``, 
``IndexOutOfBounds``, etc. Are bugs!

[Example](./learn-java/src/main/java/br/com/oopbasics/ExceptionMain.java)

### Unchecked

Do not enforce (compile-time) be declared in methods or constructors the ``throws`` clause.
But you can, is like try/catch a possibly ``NullPointerException`` for example.

### Checked

You MUST declare in a method or constructor using the ``throws``.

If you don't have a aproppriate ``catch`` for an exception the current thread end, ie. not catched.
Remember about up/down casting and dynamic type, the ``Exception`` class can catch all its subclasses, 
but if you use a more specific you can not catching and ending the thread.

## Strings 

Comparing strings, examples:

```java
//Identity -> same referenec
String a = "First String";  
String b = a;
System.out.println(a == b ? "Same reference" : "Not the same reference");
//Same reference

//The JVM will give the same address to the a2 and b2
String a2 = "First String";  
String b2 = "First String";
System.out.println(a == b ? "Same reference" : "Not the same reference");
//Same reference

//Equality -> same state
String a = "First String";  
String b = new String("First String");  //new reference
System.out.println(a.equals(b) ? "Same" : "Not the same");
//Same
```

[Example](./learn-java/src/main/java/br/com/strings/StringMain.java)

# Object Oriented Programming

Important notes about usage oop pillars.

## Inheritance

The final superclass in every hierarchy is ``Object``.

Can access overridden methods using ``super.methodName``;

- Overloading (Sobrecarga de Método): 
	-  Same method name but different parameters. 
	- Overloading happens at compile-time. The compiler will search for a more specific method call to resolve.
		- It basically says that the compiler tries to find a version of the method where all parameters including the object the method is called upon are most specific. If no such method exists (e.g. since you have `method(Base, Sub)` and `method(Sub, Base)` but not `method(Sub, Sub)`), then the compilation fails.
	- Static binding is being used for overloaded methods. 
- Overriding (Sobrescrita de Método): 
	- Same method name and parameters (i.e., method signature); 
	- Overriding happens at runtime; 
	- Dynamic binding or Late binding is being used for overriding methods.


## Abstract Classes

Must have at least one abstract method without body. Can have state, implemented methods, etc as normal class.

Use an abstract class when you want to provide a default behavior that subclasses can extend or override.
When there are shared characteristics and behaviors among a group of related classes.

[Example](./learn-java/src/main/java/br/com/oopbasics/AbstractClassMain.java)

## Interfaces

Um contrato define um determinado conjunto de métodos que serão implementados nas classes que assinarem esse contrato.

Uma interface é 100% abstrata, ou seja, os seus métodos são implicitamente abstratos, e as variáveis são implicitamente constantes (static final).

A escolha tem dois aspectos que precisam ser considerados: 
- Conceitual: 
	- Classes abstratas não podem ter instâncias; 
	- Interfaces determinam contratos. 
- Prático: 
	- Uma classe pode implementar mais de uma interface; 
	- Uma classe pode ser abstrata e pode ter atributos. 
- Importante: classes abstratas e interfaces têm como objetivo comum favorecer o uso de polimorfismo.

Use interfaces when you want to specify a set of methods that a class must implement.
When different unrelated classes need to implement common behavior without being forced into a hierarchy.

[Example](./learn-java/src/main/java/br/com/oopbasics/Printable.java)

# Generics

Primitive types is not allowed to use in generics because for compatibility reasons, all generic code is translated in compile-time and  anything that is used as generics has to be convertible to Object. Example:
```java
List<ClassA> list = new ArrayList<ClassA>();
list.add(new ClassA());
ClassA a = list.get(0);

//To...

List list = new ArrayList();
list.add(new ClassA());
ClassA a = (ClassA)list.get(0);
```

# Keywords

## ``final``

Is a ``non-access modifier``, it means that provide information to the ``JVM``. Applicable to classes, methods and variables. 

- A variable whose value you can't change after it's been initialized. Not necessary initialize when is declared.
- Parent class with a ``final`` method can't be overridden by child class. Works in outer and inner classes.
- If a class is final, it can't be extended. Every method is final too by default and every variable need to be final. Main advantage is security and unique implementation and disadvantage is not embrace OOP benefits (polymorphism, inheritance, etc).

## ``static``

Is a ``access modifier``that is applicable for methods and variables but not for top-level classes, only for inner classes (static nested class). Good choice for methods that don't require any object state manipulation. 

One rule-of-thumb: ask yourself "Does it make sense to call this method, even if no object has been constructed yet?" If so, it should definitely be static.

In contrast by instance fields, the ``static`` variables are on the class level, so its shared between all object instances having the same value and reference. Can be changed after initialization.

Static methods can only access the static members of the class and can only be called by other static methods.

Static block is used to initialize the static variables.

## ``instanceof``

Works to the same object and all parent class in hierarchy until ``Object``.


# JPA - Java Persistence API

# Relationships 

The main annotations are:
```java
@ManyToOne
@OneToMany
@OneToOne
@ManyToMany
//Properties: mappedBy

@JoinColumn
@JoinTable
//Properties: name. The column name in the table
```

There are unidirectional and bidirectional relationships, like
class A and class B then:
- Unidirectional: A.b or B.a
- Bidirectional: A.b and B.a 


Owner and Non-owning

Owner is the class that persists the in relationship, characterized by:

- Opposite to mappedBy
- Annotated with ``JoinColumn`` or ``JoinTable``

Non-owning is the other side of class. 

Without ``@JoinColumn`` the default column name is:

Property mapped name + PK table name of referenced entity. Example:

```java
class Order {
    @Id
    private Long id;
    private String itemName;
    @ManyToOne
    private Customer customer;
}

class Customer {
    @Id 
    private Long id;
    private String name;
}
```

in this case, the table name in order class to realized the relationship are ``customer_id``;