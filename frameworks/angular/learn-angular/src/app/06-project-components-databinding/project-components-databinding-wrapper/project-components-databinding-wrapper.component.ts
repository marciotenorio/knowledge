import { Component } from '@angular/core';
import { Recipe } from '../shared/recipe.model';
import { Ingredient } from '../shared/ingredient.model';

@Component({
  selector: 'app-project-components-databinding-wrapper',
  templateUrl: './project-components-databinding-wrapper.component.html',
  styleUrl: './project-components-databinding-wrapper.component.css'
})
export class ProjectComponentsDatabindingWrapperComponent {
  currentPage = 'recipe-book';
  recipes: Array<Recipe>;
  shoppingList: Array<Ingredient>;


  onSelectPage(page: string): void {
    console.log(page);
    this.currentPage = page;
  }
}
