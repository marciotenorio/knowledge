import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-root-15-handling-forms',
  templateUrl: './root-15-handling-forms.component.html',
  styleUrl: './root-15-handling-forms.component.css'
})
export class Root15HandlingFormsComponent {

  subscriptions = ['Basic', 'Advanced', 'Pro'];

  submit(form: NgForm): void {
    if(form.invalid && form.touched) alert("Formulário inválido!");
    console.log(form);
  }
}
