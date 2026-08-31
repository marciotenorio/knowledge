import { Component, OnDestroy, OnInit } from '@angular/core';
import { BehaviorSubject, Observable, Subject, Subscription } from 'rxjs';

@Component({
  selector: 'app-obs-sub-beh',
  templateUrl: './obs-sub-beh.component.html',
  styleUrl: './obs-sub-beh.component.css'
})
export class ObsSubBehComponent implements OnInit, OnDestroy {
  subs: Subscription;
  myObsSubscription: Subscription;
  mySubjectSubscription: Subscription;

  myData: number;
  mySubjectData: number;

  mySubject = new Subject<number>();
  myBehaviorSubject = new BehaviorSubject<string>('Márcio');
  myObs$ = new Observable<number>((subs) => {
    let c = 0;
    const intervalId = setInterval(() => {
      console.log('myObs$ - ' + c);
      subs.next(c);
      c++;
    }, 1000);

    return function unsubscribe() {
      clearInterval(intervalId);
    }
  });

  ngOnInit(): void {
    this.myObsSubscription = this.myObs$.subscribe(num => {
      this.myData = num;
    });
    this.mySubjectSubscription =  this.mySubject.subscribe(num => {
      this.mySubjectData = num;
    });
    
    setTimeout(_ => {
      this.mySubject.next(Math.random() * 10);
    }, 3000);
  }

  ngOnDestroy(): void {
     this.myObsSubscription.unsubscribe();
     console.log(this.mySubject.observed)
  } 

  increaseSubject(): void {
    this.mySubject.next(Math.random() * 10);
  }

  clickV2(): void {
    console.log('entrou no deactivate do obs');
    this.myObsSubscription.unsubscribe();
  }

}
