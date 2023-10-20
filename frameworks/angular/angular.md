# Angular Reference

# Summary

- [. . /Frameworks](../frameworks.md)
- [Start](#start)
- [Forms](#forms)
- [Components](#components)
- [Data Binding](#data-binding)
- [Directives](#directives)


## Start
- Angular changes DOM at runtime. He uses shadow DOM to improve speed and changes in an optimized way.
  
- How a SPA, the deployed file is the index.html. Knowing the tag name of the custom element defined by the selector property in the root component (app.component.ts), in this case 'app-root', Angular will render this component inside index.html body on <app-root> custom element.
  
- How Angular starts to run custom element <app-root> inside index.html:
The final file deployed is filled with Javascript bundles imports that are injected by the ng serve process between rebuilds. So in the final bundle, there will exists our code too.

- The first code executed is from main.ts. It imports the app.module and passes it to Angular's boostrap/start method to initialize the application. The boostrap array in app.module.ts has all the components that should be known to Angular when parsing index.html. Here the cycle of references closes because I am referencing the app itself.

- So the summary: Angular starts with main.ts which receives the AppModule as an argument. In this module we tell Angular in the boostrap array which components it should know when starting itself (the module itself, because you should remember that we can have multiple modules. In the next chapters). Angular parses it, reads its setup and knows its ``app-root`` selector. Now he knows how to deal with the custom tag in index.html ``<app-root>``, as he knows the selector described by knowing the component and its dependencies in the boostrap array. Now he knows that he should insert the component here and he has some HTML in this case he inserts what he has in app.component.html.

## Forms

It's only possible to use ``[(ngModel)]="name"`` if the ``import {FormsModule} from '@angular/forms'`` dependency are imported in ``app.module.ts`` like [here](first-app/src/app/app.module.ts).

## Components
- New components are created inside ``app`` folder by the CLI using:  
  > ``ng generate component name-component`` 
  
  > ``ng g c name-component``
- The angular selectors starts with ``app-`` because are encouraged by the angular to follow the convention about custom elements. You can remove this manually or remove in the "prefix" property on the angular.json.
- Angular use componentes to build web pages and modules to bundle difference pieces in to packages.
- Modules in Angular are containers for cohesive code blocks to an application domain, workflow or closed related capabilities. 
- Selector are used as the custom element name. 
- All component must have a template. It can be a ``templateUrl`` in ``@Component`` pointing to external file or a ``template`` that is a html directly in the property.
- A component can have multiple external css files, inline styles have high precendente and you can use multiples strings to define css. Css are only applied to elements beloging to the component.
- Can i have selector that act like a custom element, a property or class like [here](first-app/src/app/servers/servers.component.ts).

## Data Binding
- Binding possibilities:
  - TS -> TEMPLATE: String interpolation ``{{ data }}`` or property binding ``[property] = "data"``. One-way. 
  - TS <- TEMPLATE: User events like ``(event) = "expression"``. One-way.
  - TS <-> TEMPLATE: ``[(ngModel)] = "data"``. Two-way.

- In string interpolation i can: ``{{ TS expression that can be resolve a string  }}``. You can't use multline and codeblocks expressions (if, for, etc).
- Surrounding a property with [] tell to angular that you are using property binding. For each attribute you can have a type to be resolved,  ex: in ``[disabled]="will be resolve to boolean"`` inside quotes in this case everything will try to be resolve as a boolean value.
- Two-way databinding are a combination of property and event binding: ``[(ngModel)]``.
- Types: interpolation, event, property and two-way.


## Directives
 - ``*`` is an extra information to Angular that the ``ngIf`` for example(or whatever directive is) changes de structure of DOM adding or not an element. So must use ``*ngIf``.
 - ``#something`` in else are a local reference (deep later).
 - Remember that directives are different than property binding, so, ``ngStyle`` is a directive when used like ``[ngStyle]`` you are indicating that you are binding a property called ``ngStyle`` in one-way binding. We are binding to a property of the directive.