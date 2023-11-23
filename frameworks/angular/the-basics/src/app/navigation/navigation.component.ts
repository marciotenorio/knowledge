import { Component } from '@angular/core';

@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html',
  styleUrls: ['./navigation.component.css']
})
export class NavigationComponent {

  public page = "supplements";
  public supplementsActive = true;
  public shoppingListActive = false;

  changePage(page: string){
    this.page = page;

    if(page === 'supplements'){
      this.supplementsActive = true;
      this.shoppingListActive = false;
    }
    else if(page == 'shoppingList'){
      this.supplementsActive = false;
      this.shoppingListActive = true;
    }


  }
}
