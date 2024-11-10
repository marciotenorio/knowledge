import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-reactive-approach',
  templateUrl: './reactive-approach.component.html',
  styleUrl: './reactive-approach.component.css'
})
export class ReactiveApproachComponent implements OnInit {
  genders = ['Male', 'Female'];

  signupForm: FormGroup;

  ngOnInit(): void {
    this.signupForm = new FormGroup({
      userData: new FormGroup({
        username: new FormControl(null, Validators.required),
        email: new FormControl(null, [Validators.required, Validators.email])
      }),
      gender: new FormControl('Male'),
    });
  }

  onSubmit(): void {
    console.log(this.signupForm);
  }
}
