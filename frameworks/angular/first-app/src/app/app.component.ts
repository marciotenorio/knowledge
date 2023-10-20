import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
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
export class AppComponent {
  title = 'first-app';
}
