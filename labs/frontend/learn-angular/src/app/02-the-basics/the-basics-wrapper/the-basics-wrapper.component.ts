import { Component } from '@angular/core';

@Component({
  selector: 'app-the-basics-wrapper',
  templateUrl: './the-basics-wrapper.component.html',
  styleUrl: './the-basics-wrapper.component.css',
  /**
   * Styles have high precedence
   */
  styles: [`
      h3 {
        color: red;
      }
  `,
  `
      span {
        background-color: green;
      }
  `
  ]
})
export class TheBasicsWrapperComponent {

}
