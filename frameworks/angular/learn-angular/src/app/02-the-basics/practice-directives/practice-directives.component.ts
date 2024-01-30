import { Component } from '@angular/core';

@Component({
  selector: 'app-practice-directives',
  templateUrl: './practice-directives.component.html',
  styleUrls: ['./practice-directives.component.css']
})
export class PracticeDirectivesComponent {
  showParagraph = true;
  clicks: Date[] = [];
  
  btnClick(): void {
    this.clicks.push(new Date());
    this.showParagraph = !this.showParagraph;
  }
}
