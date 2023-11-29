import { 
  AfterContentChecked,
  AfterContentInit,
  Component, 
  DoCheck, 
  Input,
  OnChanges,
  OnInit, 
  SimpleChanges, 
  ViewEncapsulation,
  AfterViewInit,
  AfterViewChecked,
  OnDestroy
} from '@angular/core';

@Component({
  selector: 'app-server-element',
  templateUrl: './server-element.component.html',
  styleUrls: ['./server-element.component.css'],
  encapsulation: ViewEncapsulation.Emulated
})
export class ServerElementComponent implements 
  OnInit, 
  OnChanges, 
  DoCheck, 
  AfterContentInit,
  AfterContentChecked, 
  AfterViewInit,
  AfterViewChecked,
  OnDestroy
  {

  @Input('srvElement') element: {type: string, name: string, content: string}
  @Input() name: string;

  constructor() {
    console.log('constructor called!');
  }

  /**
   * It's a good practice always implement the lifecycle hooks interface.
   * To be clear which lifecycle hooks are implemented.
   */
  ngOnChanges(changes: SimpleChanges): void {
    //Called before any other lifecycle hook. Use it to inject dependencies, 
    //but avoid any serious work here.
    // Good to work with old and new values of the input properties.
    //Add '${implements OnChanges}' to the class.
    console.log('ngOnChanges called!');
    console.log(changes);
  }

  ngOnInit(): void {
    //Called after the constructor, initializing input properties, and the
    //first call to ngOnChanges.
    //Add 'implements OnInit' to the class.
    console.log('ngOnInit called!');
  }

  ngDoCheck(): void {
    //Called every time that the input properties of a component or 
    //a directive are checked. Use it to extend change detection by performing
    // a custom check.
    //Add 'implements DoCheck' to the class.
    console.log('ngDoCheck called!');
  }

  ngAfterContentInit(): void {
    //Called after ngOnInit when the component's or directive's content
    // has been initialized.
    //Add 'implements AfterContentInit' to the class.
    console.log('ngAfterContentInit called!');
  }

  ngAfterContentChecked(): void {
    //Called after every check of the component's or directive's content.
    //Add 'implements AfterContentChecked' to the class.
    console.log('ngAfterContentChecked called!');
  }
  
  ngAfterViewInit(): void {
    //Called after ngAfterContentInit when the component's view has 
    //been initialized. Applies to components only.
    //Add 'implements AfterViewInit' to the class.
    console.log('ngAfterViewInit called!'); 
  }  

  ngAfterViewChecked(): void {
    //Called after every check of the component's view. Applies to 
    //components only.
    //Add 'implements AfterViewChecked' to the class.
    console.log('ngAfterViewChecked called!');
  }

  ngOnDestroy(): void {
    //Called once, before the instance is destroyed.
    //Add 'implements OnDestroy' to the class.
    console.log('ngOnDestroy called!');
  }
}
