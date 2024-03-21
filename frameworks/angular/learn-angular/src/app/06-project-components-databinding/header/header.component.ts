import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrl: './header.component.css'
})
export class HeaderComponent {
  @Output() currentPage = new EventEmitter<string>;

  onSelect(page: string): void {
    this.currentPage.emit(page);
  }
}
