# Java Reference

## Summary

- [. . /Languages](../languages.md)
- [JPA](#jpa---java-persistence-api)


### JPA - Java Persistence API

#### Relationships 

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