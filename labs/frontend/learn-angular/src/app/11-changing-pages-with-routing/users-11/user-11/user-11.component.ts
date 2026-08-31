import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-user-11',
  templateUrl: './user-11.component.html',
  styleUrls: ['./user-11.component.css']
})
export class User11Component implements OnInit, OnDestroy {
  user: {id: number, name: string};
  routeSubscriotion: Subscription;

  constructor(private route: ActivatedRoute) { }

  ngOnInit() {
    //Used if open only one time and url doesn't changed on the page
    this.user = {
      id: this.route.snapshot.params['id'],
      name: this.route.snapshot.params['name']
    };

    //If url change on the page
    this.routeSubscriotion = this.route.params.subscribe(
      (params: Params) => {
        this.user.id = params['id'],
        this.user.name = params['name']
      }
    )
  }

  ngOnDestroy(): void {
      //Only to remember to always unsubscribe ours observables, because in this case Angular behind the scenes unsubscribe the
      //route.params observable when its component are destroyed.
      this.routeSubscriotion.unsubscribe();
  }
}
