import { Component, OnDestroy, OnInit } from '@angular/core';
import { AbstractControl, FormArray, FormControl, FormGroup, Validators } from '@angular/forms';
import { forbiddenText } from './customValidators';
import { Observable, Subscription } from 'rxjs';

@Component({
  selector: 'app-reactive-approach',
  templateUrl: './reactive-approach.component.html',
  styleUrl: './reactive-approach.component.css'
})
export class ReactiveApproachComponent implements OnInit, OnDestroy {
  genders = ['Male', 'Female'];
  forbiddenUserNames = ['Tenorio'];

  signupForm: FormGroup;
  subscriptions = new Array<Subscription>;

  ngOnInit(): void {
    this.signupForm = new FormGroup({
      userData: new FormGroup({
        username: new FormControl(null, [
          Validators.required, this.forbiddenNamesValidator.bind(this)]),
        email: new FormControl(null, [
          Validators.required, Validators.email, forbiddenText(/a@a/i)], [this.forbiddenEmails])
      }),
      gender: new FormControl('Male'),
      hobbies: new FormArray([])
    });

    this.subscriptions.push(
      this.signupForm.statusChanges.subscribe(
        value => console.log(`--- STATUS = ${value}`)
      )
    );

    this.subscriptions.push(
      this.signupForm.valueChanges.subscribe(
        value => console.log(`--- VALUE =`, value)
      )
    );
  }

  ngOnDestroy() {
    this.subscriptions.forEach(s => s.unsubscribe());
  }

  get hobbieControls() {
    return (this.signupForm.get('hobbies') as FormArray).controls;
  }

  onSubmit(): void {
    console.log(this.signupForm);
  }

  onAddHobbie(): void {
    const hobbie = new FormControl(null, [Validators.required]);
    // (this.signupForm.get('hobbies') as FormArray).push(hobbie);
    (<FormArray>this.signupForm.controls['hobbies']).push(hobbie);
  }

  forbiddenNamesValidator(control: AbstractControl): {[s: string]: boolean} {
    if(this.forbiddenUserNames.indexOf(control.value) !== -1) {
      return {'Name is forbidden': true};
    }
    return null;
  }

  forbiddenEmails(control: AbstractControl): Promise<any> | Observable<any> {
    const promise = new Promise<any>((resolve, reject) => {
      setTimeout(() => {
        if(control.value === 't@t') {
          resolve({'emailIsForbidden': true});
        }
        else {
          resolve(null);
        }
      }, 1500);
    });
    return promise;
  }
}
