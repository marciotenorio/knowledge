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
  
- How a SPA the deployed file is the index.html. Knowing the tag name of the custom element defined by the selector property in the root component (app.component.ts), in this case 'app-root', Angular will render this component inside index.html body on <app-root> custom element.
  
- How Angular starts to run custom element <app-root> inside index.html:
The final file deployed is filled with Javascript's bundle imports that are injected by the ng serve process between rebuilds. So in the final bundle, there will exists our code too.

- O primeiro código executado é o do main.ts. Ele importa o app.module e passa para o método de boostrap/start do angular para inicalizar a aplicação. 
  The boostrap array in app.module.ts tem todos os componentes que devem ser conhecidos pelo Angular ao analizar o index.html. Aqui o ciclo das referências se fecham por que estou referenciando o próprio app.

- Então o resumo: O Angular starta começando pelo main.ts que recebe o AppModule como argumento. Neste módulo nos dizemos ao angular no array boostrap quais componentes ele deve conhecer quando startar ele mesmo (o próprio módulo). O angular o analisa, lê seu setup e conhece seu seletor 'app-root'. Agora ele sabe como lidar com a custom tag no index.html <app-root>, pois ele conhece o seletor descrito atráves de conhecer o componente e suas dependências no boostrap array. Agora ele sabe que deve inserir o componente aqui e ele tem algum HTML no caso ele insere o que tem em app.component.html. 

## Forms

It's only possible to use ``[(ngModel)]="name"`` if the ``import {FormsModule} from '@angular/forms'`` dependency are imported in ``app.module.ts``


## Components
- New components are created inside 'app' folder by the CLI.  
- The angular selectors starts with 'app-' because are encouraged by the angular to follow the convention about custom elements. You can remove this manually or remove in the "prefix" property on the angular.json.
- Angular use componentes to build web pages and modules to bundle difference pieces in to packages.
- Modules in Angular are containers for cohesive code blocks to an application domain, workflow or closed related capabilities. 
- Creating componentes using CLI:
  ng generate component name-component 
  ng g c name-component

- selector are used as the custom element name. 
- All component must have a template. It can be a 'templateUrl' in @Component pointing to external file or a 'template' that is a html directly in the property.
- A component can have multiple external css files, inline styles have high precendente and you can use multiples strings to define css. Css are only applied to elements beloging to the component.
- Can i have selector that act like a custom element, a property or class.



## Data Binding
- TS -> TEMPLATE: String interpolation {{ data }} or property binding [property] = "data" 
  TS <- TEMPLATE: User events like (event) = "expression"
  TS <-> TEMPLATE: [(ngModel)] = "data"

- In string interpolation i can: {{ TS expression that can be resolve a string  }}. You can't use multline and codeblocks expressions (if, for, etc).
- [] tell to angular that you are using property binding. For each attribute you can have a type to be resolved,  ex: in [disabled]="" inside quotes in this case everything will try to be resolve as a boolean value.
- Two-way databinding are a combination of property and event binding: [(ngModel)].
- Types: interpolation, event, property and two-way.


## Directives
 - '*' a extra information to Angular that the ngIf change de structure of DOM add or not a element. So *ngIf.
 - '#something' in else are a local reference (deep later).
 - 