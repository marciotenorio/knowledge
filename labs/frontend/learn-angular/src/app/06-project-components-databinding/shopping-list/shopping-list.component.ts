import { Component, Input, Output, QueryList, ViewChildren } from '@angular/core';
import { Ingredient } from '../shared/ingredient.model';

@Component({
  selector: 'app-shopping-list',
  templateUrl: './shopping-list.component.html',
  styleUrl: './shopping-list.component.css'
})
export class ShoppingListComponent {
  @Input() ingredients: Array<Ingredient>;
  @Output() newIngredient: Ingredient;
  
}
