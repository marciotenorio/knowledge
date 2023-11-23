import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-supplements-list',
  templateUrl: './supplements-list.component.html',
  styleUrls: ['./supplements-list.component.css']
})
export class SupplementsListComponent implements OnInit{

  supplements: Supplement[] = [];
  //reactive
  total: number;

  ngOnInit(): void {
    //Called after the constructor, initializing input properties, and the first call to ngOnChanges.
    //Add 'implements OnInit' to the class.
    this.supplements.push(
      new Supplement("Creatina", "Força", "Mais força e melhor recuperaçao.", 44.25),
      new Supplement("Whey Protein", "Massa Muscular", "Proteína do soro do leite.", 98.25),
      new Supplement("BCAA", "Recuperação", "Melhor recuperação do treino.", 24.82)
    )

    this.calcTotal();
  }

  calcTotal(){
    this.total = this.supplements
    .map(s => s.price)
    .reduce((prev, curr) => prev + curr, 0);
  }

  remove(supplement: Supplement){
    this.supplements.splice(this.supplements.indexOf(supplement), 1);
    this.calcTotal();
  }
}

class Supplement {
  name: string;
  category: string;
  description: string;
  price: number;

  constructor(name: string, category: string, description: string, price: number){
    this.name = name;
    this.category = category;
    this.description = description;
    this.price = price;
  }
}
