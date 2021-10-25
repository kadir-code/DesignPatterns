# DesignPatterns
In this project, I tried to apply some design patterns with sample projects.


## Abstract Factory Design Pattern

[Go To Example](https://github.com/kadir-code/DesignPatterns/tree/master/AbstractFactory)

Factory Method D.P.; It aims to produce more than one relational object with a request to be made through a single class through a common interface and to reduce the dependency of the client on the produced object to zero at the time of object production.

Abstract Factory D.P. On the other hand, it provides the production of more than one relational object not by a single interface, but by defining a different interface for each product family.

So as a result, in cases where we have to work with more than one product family, Abstract Factory D.P. is used to abstract the client from these structures. It would be the right approach.
## Bridge Design Pattern

[Go To Example](https://github.com/kadir-code/DesignPatterns/tree/master/BridgeDesignPattern)

<img src="http://cagataykiziltan.net/wp-content/uploads/2018/09/bridgepattern1.png" width="600" height="200" />


> The Bridge design pattern is used to distinguish implementations from abstracts.

### When to Use the Bridge Design Pattern?

   * If you want to completely separate the implementations from the client…
   * If you don't want to bind the implementations directly to the abstraction that communicates with the client...
   * If you want to make changes within the implementations without even rebuilding the Abstraction class...

## Builder Design Pattern

[Go To Example](https://github.com/kadir-code/DesignPatterns/tree/master/BuilderPattern)

<img src="https://ibrahimbelkhiria.com/wp-content/uploads/2018/08/xebia-builder-officiel.png " width="500" height="300" />


The Builder design pattern is used to create objects of different shapes, so that the client can perform the creation by specifying only the object type. In the Builder design pattern, it is thought that a product that the client wants to use can have more than one shape. The builder pattern is responsible for producing the object with different shapes. Therefore, the client is abstracted from this work.

## Decorator Design Pattern

[Go To Example](https://github.com/kadir-code/DesignPatterns/tree/master/DecoratorDesignPattern)

<img src="http://cagataykiziltan.net/wp-content/uploads/2018/09/decorator.png" width="600" height="200" />


The purpose of the Decorator design pattern is to add properties to objects dynamically, and the object itself must be in a separate location, unaware of the properties being added. In other words, if we want to give certain properties to objects in certain parts of the code and we want to do this in a way that is separated from the object's own class, we should use the decorator design pattern.

## Factory Method Design Pattern

[Go To Example](https://github.com/kadir-code/DesignPatterns/tree/master/FactoryMethodPattern)

![alt text for screen readers](http://cagataykiziltan.net/wp-content/uploads/2018/09/factory-300x255.jpg )

The Factory Method design pattern is one of the patterns used to produce objects with inherited relationships. The main thing here is a method. The job undertaken by this method is to ensure that the actual products needed by the client are produced. A polymorphic type is used so that a single class and method can assume this. Accordingly, a parent class and subclasses derived from this parent class are used.

## Mediator Design Pattern

[Go To Example](https://github.com/kadir-code/DesignPatterns/tree/master/MediatorDesignPattern)

![alt text for screen readers](https://www.gencayyildiz.com/blog/wp-content/uploads/2021/02/C-Mediator-Design-PatternMediator-Tasarim-Deseni-5.png )

We can use the Mediator design pattern when we want to manage a group of related objects from a single center and establish loosely coupled systems between them.

Cases where we can use the mediator pattern;

* If you have multiple objects in interaction that refer to each other
* If we want to manage these relationships in a different layer

## Observer Design Pattern


[Go To Example](https://github.com/kadir-code/DesignPatterns/tree/master/ObserverDesignPattern)

<img src="https://www.researchgate.net/profile/Mohammad_Bsoul/publication/273871945/figure/fig6/AS:668638759624718@1536427311654/A-simplified-UML-class-diagram-for-the-Observer-design-pattern.png" width="400" height="250" />

Observer is a design pattern that functions like the meaning of the watcher or the overseer. We are talking about a design that notifies other objects of these changes when there is any change in the state of the existing object. To be more precise, when an update, change or realization of a certain condition occurs in the "y" property of the "x" object, other "z", "w", "k" ws. we call the system that notifies the objects of this new state the Observer design pattern.

## Prototype Design Pattern

[Go To Example](https://github.com/kadir-code/DesignPatterns/tree/master/PrototypeDesignPattern)

<img src="https://www.tutorialspoint.com/design_pattern/images/prototype_pattern_uml_diagram.jpg" width="500" height="330" />

Since creating objects with the new operator has a cost, this is one of the design patterns aimed at reducing the cost. What the prototype design pattern tells us is that if you have an object and you have to create an exact copy of that object many times, don't create it from scratch, instead take clones of the object you have. So, as the name suggests, an object becomes a prototype. Other objects are also produced from this prototype.

## Singleton Design Pattern

[Go To Example](https://github.com/kadir-code/DesignPatterns/tree/master/SingletonPattern)

![alt text for screen readers](https://refactoring.guru/images/patterns/diagrams/singleton/structure-en.png?id=4e4306d3a90f40d74c7a )

The singleton design pattern belonging to the Creational design patterns group controls the generation of an object until the application pool is closed, and that it does not have a single instance. At the same time, this object is accessible from outside the class. It is used when only one instance of a class is desired at a time. The constructor method of the class to which the singleton pattern will be applied is defined as private and a static class of its own type is defined inside the class. A method or property that will provide access to this defined class is also added to the class.








