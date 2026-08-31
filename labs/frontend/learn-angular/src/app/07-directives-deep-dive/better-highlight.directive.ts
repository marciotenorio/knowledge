import { Directive, ElementRef, HostBinding, HostListener, Input, OnInit, Renderer2 } from '@angular/core';

@Directive({
  selector: '[appBetterHighlight]'
})
export class BetterHighlightDirective implements OnInit{
  @Input() defaultColor = 'transparent';
  // Creating a alias to self enclose like a 'native html attribute'.
  @Input('appBetterHighlight') highlightColor = 'blue';
  //Is not initialized here because Inputs are filled after the backgroundColor being created.
  //So, put in ngOnInit
  @HostBinding('style.backgroundColor') backgroundColor: string;

  constructor(
    private elRef: ElementRef,
    private renderer: Renderer2
  ) { }

  ngOnInit() {
    // this.renderer.setStyle(this.elRef.nativeElement, 'background-color', 'blue');
    this.backgroundColor = this.defaultColor;
  }

  @HostListener('mouseenter') mouseover(event: Event) {
    // this.renderer.setStyle(this.elRef.nativeElement, 'background-color', 'blue');
    this.backgroundColor = this.highlightColor;
  }

  @HostListener('mouseleave') mouseleave(event: Event) {
    // this.renderer.setStyle(this.elRef.nativeElement, 'background-color', 'transparent');
    this.backgroundColor = this.defaultColor;
  }


}
